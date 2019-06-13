using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampe : MonoBehaviour {

    public int vie;
    private int vieMax;
    public float colorIndicator;
    float vieVariation;

	// Use this for initialization
	void Start () {
        vie = GameManager.Singleton.vie;
        vieMax = GameManager.Singleton.vie;
    }
	
	// Update is called once per frame
	void Update () {

        vie = GameManager.Singleton.vie;

        vieVariation = (((vie*1f) + 0.01f) / (vieMax * 1f) * colorIndicator);

        Debug.Log(vieVariation);

        GetComponent<Light>().color = Color.Lerp(Color.red, Color.white, vieVariation);
    }
}
