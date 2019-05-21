using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopSpawnerWeapon : MonoBehaviour {

    public GameObject weapon;
    public int price;
    public Transform spawnPoint;
    public Text textsForPrice;
    public GameObject UIfeedback;

	// Use this for initialization
	void Start ()
    {
         textsForPrice.text = price.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("laserAchat") && GameManager.Singleton.score >= price)
        {
            Instantiate(weapon, spawnPoint.position, spawnPoint.rotation);
            Instantiate(UIfeedback, transform.position, transform.rotation);
            GameManager.Singleton.score -= price;
        }

        
    }
}
