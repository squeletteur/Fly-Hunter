using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Singleton;

    public int score = 0;
    public int vie = 200;
    public int wave = 0;
    public int sousvague = 1;
    bool interWave = true;

    public List<GameObject> ennemys;
    private List<float> ennemysCDWave1;
    private List<float> ennemysCDWave2;
    private List<float> ennemysCDWave3;

    public Transform positionsParent;

    public float waveDuration;
    public float waveDurationActual;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Singleton = this;
        }
    }

    // Use this for initialization
    void Start ()
    {
        waveDurationActual = waveDuration;

        ennemysCDWave1 = new List<float>();
        ennemysCDWave2 = new List<float>();
        ennemysCDWave3 = new List<float>();

        for (int i = 0; i < ennemys.Count; i++)
        {
            Debug.Log(i);
            ennemysCDWave1.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave1CD());
            ennemysCDWave2.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave2CD());
            ennemysCDWave3.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave3CD());
            Debug.Log(ennemysCDWave1[i]);
        }

        StartWave();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ((wave == 1) && (interWave == false))
        {
            waveDurationActual -= Time.deltaTime;

            if (waveDurationActual <= 0)
            {
                waveDurationActual = waveDuration;
                interWave = true;
            }

            for (int i = 0; i < ennemys.Count; i++)
            {
                bool isIn = ennemys[i].GetComponent<EnnemyScript>().IsHeInWave1();

                if (isIn == true)
                {
                    ennemysCDWave1[i] -= Time.deltaTime;

                    if (ennemysCDWave1[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave1CD();
                        ennemysCDWave1[i] = CD;
                    }
                }
            }
        }

        if ((wave == 2) && (interWave == false))
        {
            waveDurationActual -= Time.deltaTime;

            if (waveDurationActual <= 0)
            {
                waveDurationActual = waveDuration;
                interWave = true;
            }

            for (int i = 0; i < ennemys.Count; i++)
            {
                bool isIn = ennemys[i].GetComponent<EnnemyScript>().IsHeInWave2();

                if (isIn == true)
                {
                    ennemysCDWave2[i] -= Time.deltaTime;

                    if (ennemysCDWave2[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave2CD();
                        ennemysCDWave2[i] = CD;
                    }
                }
            }
        }

        if ((wave == 3) && (interWave == false))
        {
            waveDurationActual -= Time.deltaTime;

            if (waveDurationActual <= 0)
            {
                waveDurationActual = waveDuration;
                interWave = true;
            }

            for (int i = 0; i < ennemys.Count; i++)
            {
                bool isIn = ennemys[i].GetComponent<EnnemyScript>().IsHeInWave3();

                if (isIn == true)
                {
                    ennemysCDWave3[i] -= Time.deltaTime;

                    if (ennemysCDWave3[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave3CD();
                        ennemysCDWave3[i] = CD;
                    }
                }
            }
        }

        if (Input.GetKeyDown("space"))
            {
            StartWave();
        }
    }

    public void Spawn(int ennemyIndex)
    {
        Instantiate(ennemys[ennemyIndex], positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
    }

    public void StartWave()
    {
        wave++;
        interWave = false;
    }

}
