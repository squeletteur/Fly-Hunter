using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlalum : MonoBehaviour {

    public float slalumSpeed;

    public float timeToReverse;
    private float timeToReverseInitial;
    private float direction = 1;

	// Use this for initialization
	void Start () {
        timeToReverseInitial = timeToReverse;

    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * slalumSpeed * direction * Time.deltaTime);
    }

    // Update is called once per frame
    void Update () {
        timeToReverse -= Time.deltaTime;

        if (timeToReverse <= 0)
        {
            direction = direction * -1;
            timeToReverse = timeToReverseInitial;
        }
	}
}
