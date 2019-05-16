using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perso : MonoBehaviour
{
    public int health = 100;
    public int damage = 20;

    public EnnemyBasicsMovements enemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
       
            health -= damage;

        }
    }
    */
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Debug.Log("fonctionne");
            Destroy(gameObject);

            health -= damage;

            enemy = collision.gameObject.GetComponent<EnnemyBasicsMovements>();
            enemy.stun();
        }
    }*/
}
