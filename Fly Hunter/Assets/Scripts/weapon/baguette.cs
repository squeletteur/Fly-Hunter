using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baguette : MonoBehaviour {
    
    public bool grav = false;
    public Rigidbody rigidbody;

    

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(grav)
        {
            Vector3 newG = new Vector3(0, 9.81f, 0);
            
            rigidbody.AddForce(newG);
            
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.CompareTag("baguetteCollid"))
       {
            grav = true;

       }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("baguetteCollid"))
        {
            grav = true;

        }
        
    }

}
