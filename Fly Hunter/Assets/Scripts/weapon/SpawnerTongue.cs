using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTongue : MonoBehaviour {

    public GameObject tongue;
    private float distance;

	// Use this for initialization
	void Start () {
        Instantiate(tongue);
    }
	
	// Update is called once per frame
	void Update () {
        /*
        distance = Vector3.Distance(tongue.GetComponent<Transform>().transform.position, transform.position);

        if(distance > 1)
        {
            Invoke("spawn", 2f);
        }
        */

	}
    /*
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("tongue"))
        {
            Invoke("spawn", 2f);
        }
    }

    */

    public void Spawn()
    {
        //Instantiate(tongue);
    }
}
