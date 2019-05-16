using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spray : MonoBehaviour {


    public ParticleSystem sprayEffect;
    public GameObject spraycube;
    public bool OnSpray = false;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OnSpray == true)
        {
            spraycube.SetActive(true);

            if (!sprayEffect.isPlaying)
            {
                active();
                sprayEffect.Play();
            }
            
        }

        if (OnSpray == false)
        {
            spraycube.SetActive(false);

            if (sprayEffect.isPlaying)
            {
                inactive();
                sprayEffect.Stop();
            }
        }
    }

    public void active()
    {
        //sprayEffect.SetActive(true);
        sprayEffect.Play();

    }

    public void inactive()
    {
        //sprayEffect.SetActive(false);
        sprayEffect.Stop();
    }



}
