﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateItem : MonoBehaviour {
    //initier la liste
    

    public float rotationSpeed;
  
   

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

       

     
            transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed);
        
        

    }


}
