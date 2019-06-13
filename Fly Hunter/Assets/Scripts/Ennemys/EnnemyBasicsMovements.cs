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

    public int damageTapette = 50;
    public int damageSpray = 50;
    public int damageLaser = 50;
    public int damageMobilier = 50;
    public int damagePistolet = 50;
    public int damageBaguette = 50;
    public int damageThor = 50;
    public GameObject thunder;
    public GameObject bonusThorDamage;

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

    private int effetChoose;
    public GameObject effet1;
    public GameObject effet2;
    public GameObject effet3;




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
            

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damageTapette;
            degat.Play();
            Invoke("effet", 0f);
            Invoke("stun", 0.5f);
        }

        if (other.CompareTag("tapetteThorCollid"))
        {
            active = false;
            

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damageThor;
            degat.Play();
            Invoke("effet", 0f);
            Invoke("stun", 0.5f);
        }

        if (other.CompareTag("tapetteThorCollid2"))
        {
            active = false;
            Instantiate(thunder, transform.position, transform.rotation);
            thunder.transform.parent = gameObject.transform;

            Instantiate(bonusThorDamage);

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damageThor;
            degat.Play();
            Invoke("effet", 0f);
            Invoke("stun", 0.5f);
        }


        if (other.CompareTag("tongue"))
        {
            active = false;

            //Destroy(other);
            


            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damageTapette;
            degat.Play();
            Invoke("effet", 0f);
            Invoke("stun", 0.5f);
        }


        if (other.CompareTag("sabreCollid"))
        {
            active = false;
            

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damageLaser;
            degat.Play();
            Invoke("effet", 0f);
            Invoke("stun", 0.5f);
        }
        
        if (other.CompareTag("mobilierCollidDamage"))
        {
            

            active = false;
            

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damageMobilier;
            degat.Play();
            Invoke("effet", 0f);
            Invoke("stun", 0.5f);
        }

        if (other.CompareTag("baguetteCollid"))
        {
            active = false;
           

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damageBaguette;
            degat.Play();
            Invoke("effet", 0f);
            Invoke("stun", 0.5f);
        }

        if (other.CompareTag("player"))
        {
           
            GameManager.Singleton.vie -= damageDoPlayer;

            health = 0;
            degat.Play();
            Instantiate(bloodPlayer, transform.position, transform.rotation);
        }

        if (other.CompareTag("sprayCollider"))
        {
            active = false;
            

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damageSpray;
            degat.Play();
            Invoke("effet", 0f);
            Invoke("stun", 0.5f);
        }



    }

    public void effet()
    {
        Instantiate(blood, transform.position, transform.rotation);

        effetChoose = Random.Range(0, 2);

        if (effetChoose == 0)
        {
            Instantiate(effet1, transform.position, transform.rotation);
        }
        if (effetChoose == 1)
        {
            Instantiate(effet2, transform.position, transform.rotation);
        }
        if (effetChoose == 2)
        {
            Instantiate(effet3, transform.position, transform.rotation);
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
        Destroy(gameObject);
        
        GameManager.Singleton.score += ajoutScore;
    }

   public bool isDeadAsking()
    {
        return isDead;
    }

   
}
