using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perso : MonoBehaviour
{
    public int health = 100;
    public int damage = 20;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
       

            health -= damage;

        }
    }

}
