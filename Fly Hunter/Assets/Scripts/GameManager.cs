using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private List<float> ennemysCDWave4;
    private List<float> ennemysCDWave5;
    private List<float> ennemysCDWave6;
    private List<float> ennemysCDWave7;
    private List<float> ennemysCDWave8;
    private List<float> ennemysCDWave9;
    private List<float> ennemysCDWave10;

    public Transform positionsParent;

    public float waveDuration;
    public float waveDurationActual;
    public GameObject waveNumber;
    public Text WaveNumberText;

    public GameObject parentTrophys;

    public int bonusHealth;

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
    void Start()
    {
        waveDurationActual = waveDuration;

        ennemysCDWave1 = new List<float>();
        ennemysCDWave2 = new List<float>();
        ennemysCDWave3 = new List<float>();
        ennemysCDWave4 = new List<float>();
        ennemysCDWave5 = new List<float>();
        ennemysCDWave6 = new List<float>();
        ennemysCDWave7 = new List<float>();
        ennemysCDWave8 = new List<float>();
        ennemysCDWave9 = new List<float>();
        ennemysCDWave10 = new List<float>();

        for (int i = 0; i < ennemys.Count; i++)
        {
            Debug.Log(i);
            ennemysCDWave1.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave1CD());
            ennemysCDWave2.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave2CD());
            ennemysCDWave3.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave3CD());
            ennemysCDWave4.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave4CD());
            ennemysCDWave5.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave5CD());
            ennemysCDWave6.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave6CD());
            ennemysCDWave7.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave7CD());
            ennemysCDWave8.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave8CD());
            ennemysCDWave9.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave9CD());
            ennemysCDWave10.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave10CD());
            Debug.Log(ennemysCDWave1[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //wave 1
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


        //wave2
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


        //wave3
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


        //wave4
        if ((wave == 4) && (interWave == false))
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
                    ennemysCDWave4[i] -= Time.deltaTime;

                    if (ennemysCDWave4[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave4CD();
                        ennemysCDWave4[i] = CD;
                    }
                }
            }
        }


        //wave5
        if ((wave == 5) && (interWave == false))
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
                    ennemysCDWave5[i] -= Time.deltaTime;

                    if (ennemysCDWave5[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave5CD();
                        ennemysCDWave5[i] = CD;
                    }
                }
            }
        }


        //wave6
        if ((wave == 6) && (interWave == false))
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
                    ennemysCDWave6[i] -= Time.deltaTime;

                    if (ennemysCDWave6[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave6CD();
                        ennemysCDWave6[i] = CD;
                    }
                }
            }
        }


        //wave7
        if ((wave == 7) && (interWave == false))
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
                    ennemysCDWave7[i] -= Time.deltaTime;

                    if (ennemysCDWave7[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave7CD();
                        ennemysCDWave7[i] = CD;
                    }
                }
            }
        }


        //wave8
        if ((wave == 8) && (interWave == false))
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
                    ennemysCDWave8[i] -= Time.deltaTime;

                    if (ennemysCDWave8[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave8CD();
                        ennemysCDWave8[i] = CD;
                    }
                }
            }
        }


        //wave9
        if ((wave == 9) && (interWave == false))
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
                    ennemysCDWave9[i] -= Time.deltaTime;

                    if (ennemysCDWave9[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave9CD();
                        ennemysCDWave9[i] = CD;
                    }
                }
            }
        }


        //wave10
        if ((wave == 10) && (interWave == false))
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
                    ennemysCDWave10[i] -= Time.deltaTime;

                    if (ennemysCDWave10[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWave10CD();
                        ennemysCDWave10[i] = CD;
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
        vie += bonusHealth;
        wave++;
        interWave = false;
        ShowingWaveNumber(wave, waveNumber, WaveNumberText);
        //SpawnTrophys(parentTrophys);
    }

    public void ShowingWaveNumber(float waveNumber, GameObject WaveNumber, Text WaveNumberText)
    {
        WaveNumberText.text = ("Wave " + waveNumber);
        WaveNumber.GetComponent<Animator>().SetTrigger("AnimationWaveNumber");
    }

    public void SpawnTrophys(GameObject trophysParent)
    {
        int i = Random.Range(0, trophysParent.transform.childCount);
        int n = Random.Range(0, trophysParent.transform.childCount);

        for (int x = 0; x <= trophysParent.transform.childCount; x++)
        {
            trophysParent.transform.GetChild(x).gameObject.SetActive(false);
        }

        while (i == n)
        {
            n = Random.Range(0, trophysParent.transform.childCount);
        }

        trophysParent.transform.GetChild(i).gameObject.SetActive(true);
        trophysParent.transform.GetChild(n).gameObject.SetActive(true);
    }
}
