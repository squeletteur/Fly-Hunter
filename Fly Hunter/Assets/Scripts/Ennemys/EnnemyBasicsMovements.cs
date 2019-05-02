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

    private float step;
    public Transform target;

    // Use this for initialization
    void Start()
    {

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

    }
  
    /*
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("sa marche");

        if (collision.gameObject.CompareTag("weapon"))
        {
            active = false;

            Debug.Log("sa marche");

            fly.useGravity = true;
            fly.isKinematic = false;
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {   
        if(other == tapette)
        {
            active = false;

            Debug.Log("sa marche");

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

            Debug.Log("sa marche");

            fly.useGravity = true;
            fly.isKinematic = false;

            GetComponent<Collider>().isTrigger = false;

            health -= damage;

            Invoke("stun", 0.5f);
        }


        if (other == sabre)
        {
            active = false;

            Debug.Log("sa marche");

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
    }


}
