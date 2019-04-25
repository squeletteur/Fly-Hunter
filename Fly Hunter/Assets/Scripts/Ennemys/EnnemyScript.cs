using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour {

    public float spawnCDWave1;
    public float spawnCDWave2;
    public float spawnCDWave3;

    public bool isInWave1;
    public bool isInWave2;
    public bool isInWave3;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public float GetSpawnWave1CD()
    {
        return spawnCDWave1;
    }

    public float GetSpawnWave2CD()
    {
        return spawnCDWave2;
    }

    public float GetSpawnWave3CD()
    {
        return spawnCDWave3;
    }

    public bool IsHeInWave1()
    {
        return isInWave1;
    }

    public bool IsHeInWave2()
    {
        return isInWave2;
    }

    public bool IsHeInWave3()
    {
        return isInWave3;
    }
}
