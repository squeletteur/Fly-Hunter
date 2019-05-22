using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spray : MonoBehaviour {


    public ParticleSystem sprayEffect;
    public GameObject sprayCollider;
    public bool OnSpray = false;

    public float sprayAmmos;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OnSpray == true)
        {
            sprayCollider.SetActive(true);
            active();
            sprayAmmos -= Time.deltaTime;
        }

        if (OnSpray == false)
        {
            sprayCollider.SetActive(false);
            inactive();
        }

        if (Input.GetKeyDown("space"))
        {
            OnSpray = !OnSpray;
        }

        if (sprayAmmos < 0)
        {
            Destroy(gameObject);
        }
    }

    public void active()
    {
        sprayEffect.gameObject.SetActive(true);
        //sprayEffect.Play();

    }

    public void inactive()
    {
        sprayEffect.gameObject.SetActive(false);
        //sprayEffect.Stop();
    }



}
