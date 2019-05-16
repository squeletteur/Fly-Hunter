using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour {

    public float spawnCDWave1;
    public float spawnCDWave2;
    public float spawnCDWave3;
    public float spawnCDWave4;
    public float spawnCDWave5;
    public float spawnCDWave6;
    public float spawnCDWave7;
    public float spawnCDWave8;
    public float spawnCDWave9;
    public float spawnCDWave10;


    public bool isInWave1;
    public bool isInWave2;
    public bool isInWave3;
    public bool isInWave4;
    public bool isInWave5;
    public bool isInWave6;
    public bool isInWave7;
    public bool isInWave8;
    public bool isInWave9;
    public bool isInWave10;


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

    public float GetSpawnWave4CD()
    {
        return spawnCDWave4;
    }

    public float GetSpawnWave5CD()
    {
        return spawnCDWave5;
    }

    public float GetSpawnWave6CD()
    {
        return spawnCDWave6;
    }

    public float GetSpawnWave7CD()
    {
        return spawnCDWave7;
    }

    public float GetSpawnWave8CD()
    {
        return spawnCDWave8;
    }

    public float GetSpawnWave9CD()
    {
        return spawnCDWave9;
    }

    public float GetSpawnWave10CD()
    {
        return spawnCDWave10;
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

    public bool IsHeInWave4()
    {
        return isInWave4;
    }

    public bool IsHeInWave5()
    {
        return isInWave5;
    }

    public bool IsHeInWave6()
    {
        return isInWave6;
    }

    public bool IsHeInWave7()
    {
        return isInWave7;
    }

    public bool IsHeInWave8()
    {
        return isInWave8;
    }

    public bool IsHeInWave9()
    {
        return isInWave9;
    }

    public bool IsHeInWave10()
    {
        return isInWave10;
    }
}
