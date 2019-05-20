using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    private float timerFondu;
    public float IncrTimerFondu = 0.005f;

    public GameManager GM;

    [Header("Visuels")]
    public GameObject TextGO;
    public Image ImageFonduNoir;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        GameOver();
        timerFondu += IncrTimerFondu * Time.deltaTime;
	}

    private void GameOver()
    {
        if(GM.vie <= 0)
        {
            TextGO.SetActive(true);
            ImageFonduNoir.fillAmount = timerFondu;
        }
    }
}
