using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sabreLaser : MonoBehaviour {

    public GameObject laser;


	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void degaine()
    {
        laser.SetActive(true);
       

    }

    public void rengaine()
    {
        laser.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            degaine();
        }


    }
    private void OnTriggerExit(Collider other)
    {
        rengaine();
    }
}
