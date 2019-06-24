using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tapetteThor : MonoBehaviour {

    public GameObject eclair;
    public bool charge = false;

    
    public float cooldown = 5f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (charge == true )
        {
            degaine();
            Invoke("stopEclair", cooldown);
            
        }

        if (charge == false)
        {
            rengaine();
        }
    }

    public void degaine()
    {
        eclair.SetActive(true);
    }

    public void rengaine()
    {
        eclair.SetActive(false);
    }

    public void stopEclair()
    {
        charge = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("triggerThor") && charge == false)
        {
            charge = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("triggerThor") && charge == false)
        {
            charge = true;
        }
    }
}
