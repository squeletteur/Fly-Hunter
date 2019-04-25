using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject TextScore;
    public GameObject GM;
    private Text myText;
    private GameManager GMs;

    // Use this for initialization
    void Start()
    {
        myText = TextScore.GetComponent<Text>();
        GMs = GM.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        EditTS();
    }

    void EditTS()
    {
        string example = GMs.score.ToString();
        myText.text = "Score : " + example;
        myText.color = Color.black;
    }
}