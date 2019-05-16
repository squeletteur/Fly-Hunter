using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerWeapon : MonoBehaviour {

    public GameObject weapon01;
    public GameObject weapon02;
    public GameObject weapon03;
    public GameObject weapon04;

    // Use this for initialization
    void Start () {
        Instantiate(weapon01, transform.position, transform.rotation);
        Instantiate(weapon02, transform.position, transform.rotation);
        Instantiate(weapon03, transform.position, transform.rotation);
        Instantiate(weapon04, transform.position, transform.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
