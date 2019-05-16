using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispawnObject : MonoBehaviour {

    float timer = 0;
    public float MaxTime = 5f;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= MaxTime)
        {
            Destroy(gameObject);
            return;
        }
    }
}
