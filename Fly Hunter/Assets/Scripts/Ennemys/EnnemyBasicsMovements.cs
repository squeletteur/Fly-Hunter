using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnnemyBasicsMovements : MonoBehaviour
{
    
    public Rigidbody fly;
    public bool active;

    public float speed;
    public int health = 100;
    public string type = "fly";
    public int damage = 50;
    public int damageDoPlayer = 50;
    public int ajoutScore;

    private float step;
    private GameObject targetObject;
    public Transform target;
    private perso cible;
    public Animation anim;

    public GameObject Ragdoll;
    public GameObject blood;
    public GameObject bloodPlayer;

    private bool isDead = false;

    public AudioSource degat;




    // Use this for initialization
    void Start()
    {
        targetObject = GameObject.Find("Player");
        target = targetObject.transform;


    }

    // Update is called once per frame
    void Update()
    {
        if(active)
        {
            step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
        
        if(health <= 0)
        {
            active = false;
            isDead = true;
            anim.enabled = false;
            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            Invoke("destroy", 4f);
        }

        Vector3 relativePos = target.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        if (isDead == false)
            {
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = rotation;
        }
    }
  
   

    private void OnTriggerEnter(Collider other)
    {   
        if(other.CompareTag("tapetteCollid"))
        {
            active = false;
            Instantiate(blood, transform.position, transform.rotation);

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage;
            degat.Play();
            Invoke("stun", 0.5f);
        }


        if (other.CompareTag("tongue"))
        {
            active = false;

            //Destroy(other);
            Instantiate(blood, transform.position, transform.rotation);


            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage/2;
            degat.Play();
            Invoke("stun", 0.5f);
        }


        if (other.CompareTag("sabreCollid"))
        {
            active = false;
            Instantiate(blood, transform.position, transform.rotation);

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage + damage;
            degat.Play();
            Invoke("stun", 0.5f);
        }
        
        if (other.CompareTag("mobilierCollidDamage"))
        {
            

            active = false;
            Instantiate(blood, transform.position, transform.rotation);

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage / 2;
            degat.Play();
            Invoke("stun", 0.5f);
        }

        if (other.CompareTag("baguetteCollid"))
        {
            active = false;
            Instantiate(blood, transform.position, transform.rotation);

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage;
            degat.Play();
            Invoke("stun", 0.5f);
        }

        if (other.CompareTag("player"))
        {
            Instantiate(blood, transform.position, transform.rotation);
            GameManager.Singleton.vie -= damageDoPlayer;

            health = 0;
            degat.Play();
            Instantiate(bloodPlayer, transform.position, transform.rotation);
        }

        if (other.CompareTag("sprayCollider"))
        {
            active = false;
            Instantiate(blood, transform.position, transform.rotation);

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage;
            degat.Play();
            Invoke("stun", 0.5f);
        }



    }

    public void stun()
    {
        active = true;
        fly.useGravity = false;
        fly.isKinematic = true;
        



        GetComponent<Collider>().isTrigger = true;
    }

    public void destroy()
    {
        
        //Instantiate(blood, transform.position, transform.rotation);
        //Instantiate(Ragdoll, transform.position, transform.rotation);
       

        Destroy(gameObject);
        
        GameManager.Singleton.score += ajoutScore;
    }

   public bool isDeadAsking()
    {
        return isDead;
    }

   
}
