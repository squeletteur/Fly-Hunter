using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fenetre : MonoBehaviour
{
    bool opened = true;
    public float vitesse = 0.001f;
    public int timer;
    Vector3 posClosWndw;
    Vector3 posOpWndw;

    public GameManager GM;

    // Use this for initialization
    void Start()
    {
        posClosWndw = transform.position;
        posClosWndw.y -= 2;

        posOpWndw = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Open();
        Close();
        AutoOpenFinVagues();
    }

    public void Close()
    {
        if (Input.GetKeyDown(KeyCode.E) && opened == true && transform.position != posClosWndw && GM.score >= 500)
        {
            GM.score -= 500;
            Vector3 tmp = transform.position;
            tmp.y -= 2;
            transform.position = tmp;
            if (transform.position == posClosWndw)
            {
                opened = false;
            }
        }
    }

    public void Open()
    {
        if (opened == false)
        {
            timer -= 1;

            if (timer <= 0)
            {
                Vector3 tmp = transform.position;
                tmp.y += 2;
                transform.position = tmp;
                timer = 60;
                opened = true;
            }
        }
    }

    void AutoOpenFinVagues()
    {
            transform.position = posOpWndw;
            timer = 60;
            opened = true;
    }
}
