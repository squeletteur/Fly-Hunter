using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBasicsMovements : MonoBehaviour
{

    public float speed;
    private float step;
    public Transform target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
}
