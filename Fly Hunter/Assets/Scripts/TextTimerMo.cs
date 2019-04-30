using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimerMo : MonoBehaviour
{
    public GameObject GM;
    private GameManager GMt;
    private object TextTM;


    // Use this for initialization
    void Start ()
    {
        GMt = GM.GetComponent<GameManager>();
        TextTM = GetComponent<Text>().text;
    }
	
	// Update is called once per frame
	void Update ()
    {
        TextTM = GMt.timer;
	}
}
