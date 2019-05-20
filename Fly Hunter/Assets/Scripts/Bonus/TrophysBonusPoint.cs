using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophysBonusPoint : MonoBehaviour {

    public int pointBonus;
    public int lifePoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (lifePoint <= 0)
        {
            gameObject.SetActive(false);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.CompareTag("enemy")) && (collision.gameObject.GetComponent<EnnemyBasicsMovements>().isDeadAsking() == true))
            {

            Debug.Log("fonctionne");

            Destroy(collision.gameObject);
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            GameManager.Singleton.score += pointBonus;
            lifePoint --;
            }
    }
}
