using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{

    private Transform positionsParent;

    //wave1
    public GameObject[] ennemysToSpawnWave1;
    public float[] timeBeforeSpawnWave1;
    public float[] standardIntervallSpawnWave1;
    public float[] difficultyIndicatorWave1;
    public float wavedurationWave1;
    private float timeActualInWave1;
    private float timeFromStartWave1 = 0;

    // Use this for initialization
    void Start()
    {
        positionsParent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Wave1(ennemysToSpawnWave1, timeBeforeSpawnWave1, standardIntervallSpawnWave1, difficultyIndicatorWave1, wavedurationWave1, timeFromStartWave1);
    }

    private void Wave1(GameObject[] ennemys, float[] timeBeforeSpawn, float[] standardIntervallSpawn, float[] difficultyIndicator, float duration, float timeFromStart)
    {
        float timer = Time.time - timeFromStart;
        float[] spawnIntervalAtStart = standardIntervallSpawn;

        var i = 0;

        float ennemyCount = ennemys.Length;
        Debug.Log(ennemyCount);



        /*for (i = 0; i <= ennemyCount; i++)
        {
            standardIntervallSpawn[i] --;

            standardIntervallSpawn[i] -= difficultyIndicator[i] * ((timeFromStart - timeBeforeSpawn[i]) /(duration - timer));

            if (standardIntervallSpawn[i] <= 0)
            {
                standardIntervallSpawn[i] += spawnIntervalAtStart[i];
                Instantiate(ennemys[i], positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
            }
        }*/
    }

}
