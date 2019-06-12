using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sabreLaser : MonoBehaviour {

    public GameObject laser;
    public bool OnSaber = false;


	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		if(OnSaber == true)
        {
            degaine();
        }

        if (OnSaber == false)
        {
            rengaine();
        }
    }

    public void degaine()
    {
        laser.SetActive(true);
       

    }

    public void rengaine()
    {
        laser.SetActive(false);
    }
    
}
