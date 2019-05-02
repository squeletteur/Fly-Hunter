using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimerMo : MonoBehaviour
{
    public GameObject TextMO;
    public GameObject GM;
    private GameManager GMt;
    private Text TextTM;


    // Use this for initialization
    void Start ()
    {
        GMt = GM.GetComponent<GameManager>();
        TextTM = TextMO.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        EditTextMO();   
	}

    void EditTextMO()
    {
        TextTM.text = GMt.timer.ToString();
    }
}
