using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutoUIYannick : MonoBehaviour
{
    public Text timerText;
    public float timerAmount = 120;
    private float originalTimerAmount;
    private bool canPlay = false;

    public static TutoUIYannick Singleton;

    private void Awake()
    {
        if(Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }

    // Use this for initialization
    void Start ()
    {
        originalTimerAmount = timerAmount;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(canPlay)
        {
            timerAmount -= Time.deltaTime;
            if(timerAmount <= 0)
            {
                timerAmount = 0;
                canPlay = false;
            }
            UpdateTimerDisplay();
        }
	}

    private void UpdateTimerDisplay()
    {
        timerText.text = timerAmount.ToString("0:00");
    }
}
