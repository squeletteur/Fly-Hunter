using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTimerMo : MonoBehaviour
{
    [Header ("Recup")]
    public Text TextMO;
    public GameManager GM;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        EditTextMO();   
	}

    void EditTextMO()
    {
        TextMO.text = GM.waveDurationActual.ToString();
    }
}
