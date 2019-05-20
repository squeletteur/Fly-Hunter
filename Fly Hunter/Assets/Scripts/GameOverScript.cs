using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameManager GM;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameOver();
	}

    private void GameOver()
    {
        if(GM.vie <= 0)
        {

        }
    }
}
