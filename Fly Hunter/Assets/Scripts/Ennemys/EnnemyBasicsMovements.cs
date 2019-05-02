using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBasicsMovements : MonoBehaviour
{
    public Collider tapette;
    public GameObject tongue;
    public Collider raquette;
    public Collider spray;
    public Collider sabre;
    public Rigidbody fly;
    public bool active;

    public float speed;
    public int health = 100;
    public string type = "fly";
    public int damage = 50;
    public int ajoutScore;

    private float step;
    private GameObject targetObject;
    private Transform target;
    private perso cible;




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


            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            Invoke("destroy", 3f);
        }

        Vector3 relativePos = target.position - transform.position;

        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
    }
  
   

    private void OnTriggerEnter(Collider other)
    {   
        if(other == tapette)
        {
            active = false;
            

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage;

            Invoke("stun", 0.5f);
        }


        if (other.CompareTag("tongue"))
        {
            active = false;

            Destroy(other);

            

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage;

            Invoke("stun", 0.5f);
        }


        if (other == sabre)
        {
            active = false;
            

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage + damage;

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
        Destroy(gameObject);
        
        GameManager.Singleton.score += ajoutScore;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            
            

            cible = collision.gameObject.GetComponent<perso>();

            cible.health -= damage;

            Destroy(gameObject);

        }
    }
}
