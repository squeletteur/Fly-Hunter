using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispawnOnTrigger : MonoBehaviour {

    float timer = 0;
    public float MaxTime = 5f;
    public bool active = false;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        if (active)
        {


            timer += Time.deltaTime;

            if (timer >= MaxTime)
            {
                Destroy(gameObject);
                return;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("triggerDispawn"))
        {
            active = true;
        }
    }
}
