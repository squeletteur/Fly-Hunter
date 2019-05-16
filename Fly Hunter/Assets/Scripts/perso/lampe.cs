using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampe : MonoBehaviour {

    public int vie = GameManager.Singleton.vie;
    float vieVariation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        vie = GameManager.Singleton.vie;

        if (vie <= 150)
        {
            GetComponent<Light>().color = Color.Lerp(Color.white, Color.red, vieVariation);
        }


        vieVariation = -vie;

        GetComponent<Light>().color = Color.Lerp(Color.white, Color.red, vieVariation);
    }
}
