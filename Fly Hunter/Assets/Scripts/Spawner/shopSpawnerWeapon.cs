using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopSpawnerWeapon : MonoBehaviour {

    public GameObject weapon;
    public int price;
    public Transform spawnPoint;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("laserAchat") && GameManager.Singleton.score >= price)
        {
            Instantiate(weapon, spawnPoint.position, spawnPoint.rotation);
            GameManager.Singleton.score -= price;
        }

        
    }
}
