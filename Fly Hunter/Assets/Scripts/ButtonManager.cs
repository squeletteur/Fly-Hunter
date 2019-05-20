using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

	}

    public void PlayGame()
    {
        GameObject.Find("UI Manager Menu").SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
