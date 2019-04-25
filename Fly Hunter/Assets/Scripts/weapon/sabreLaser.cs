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
        
        Destroy(gameObject);

    }

    public void rengaine()
    {
        laser.SetActive(false);
    }
}
