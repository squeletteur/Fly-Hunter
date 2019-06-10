using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour {

    public List<float> ennemysCDWave;

    public List<bool> isInWave;


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        ennemysCDWave = new List<float>();
        isInWave = new List<bool>();
    }

    public float GetSpawnWaveCD(int waveNumber)
    {
        return ennemysCDWave[waveNumber];
    }

    public bool IsHeInWave(int waveNumber)
    {
        return isInWave[waveNumber];
    }
}
