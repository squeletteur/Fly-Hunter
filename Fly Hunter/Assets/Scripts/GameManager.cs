using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Singleton;

    public AudioSource debutWave;
    public AudioSource endWave;
    public Animator microOndes;

    public AudioSource music;

    public int score = 0;
    public int vie = 200;
    public int MaxVie;
    public int wave = -1;
    bool interWave = true;

    public bool activeWave = false;
    public GameObject plat;
    public Transform platSpawn;
    public bool spawn = false;

    public GameObject UIstart;
    public GameObject UIshop;
    public Image lifeBar;

    public List<GameObject> ennemys;
    private List<float> ennemysCDWave;

    public Transform positionsParent;

    public float waveDuration;
    public float waveDurationActual;
    public GameObject waveNumber;
    public Text WaveNumberText;

    public GameObject parentTrophys;

    public int bonusHealth;

    public Text waveDurationActualShowing;
    public Text scoreShowing;

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
        

        MaxVie = vie;
        waveDurationActual = waveDuration;

        ennemysCDWave = new List<float>();

        for (int i = 0; i < ennemys.Count; i++)
        {
            ennemysCDWave.Add(ennemys[i].GetComponent<EnnemyScript>().GetSpawnWaveCD(0));
        }
    }

    // Update is called once per frame
    void Update()
    {

        //wave
        if (interWave == false)
        {
            music.Play();

            waveDurationActual -= Time.deltaTime;

            if (waveDurationActual <= 0)
            {
                
                waveDurationActual = waveDuration;
                spawn = true;
                interWave = true;
                
            }

            for (int i = 0; i < ennemys.Count; i++)
            {
                bool isIn = ennemys[i].GetComponent<EnnemyScript>().IsHeInWave(wave);

                if (isIn == true)
                {
                    ennemysCDWave[i] -= Time.deltaTime;

                    if (ennemysCDWave[i] <= 0)
                    {
                        Spawn(i);
                        float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWaveCD(wave);
                        ennemysCDWave[i] = CD;
                    }
                }
            }
        }

        waveDurationActualShowing.text = waveDurationActual.ToString("0.0");
        scoreShowing.text = score.ToString("0");
        lifeBar.fillAmount = (vie*1f) / (MaxVie*1f);

        if (/*interWave == false && */spawn)
        {
            endWave.Play();
            Instantiate(plat, platSpawn.position, platSpawn.rotation);

            

            spawn = false;
            //microOndes.SetBool("open", false);
        }


        if (Input.GetKeyDown("space") || activeWave)
        {
            UIstart.SetActive(false);
            UIshop.SetActive(true);
            

            debutWave.Play();
            StartWave();
            activeWave = false;
            //microOndes.SetBool("open", true);
        }

        if(vie <= 0)
        {
            interWave = true;
            Invoke("end", 10f);
        }
    }

    public void end()
    {
        SceneManager.LoadScene(0);
    }

    public void Spawn(int ennemyIndex)
    {
        Instantiate(ennemys[ennemyIndex], positionsParent.GetChild(Random.Range(0, positionsParent.childCount)).position, Quaternion.identity);
    }

    public void StartWave()
    {
        Debug.Log(wave);
        vie += bonusHealth;
        wave ++;

        for (int i = 0; i < ennemys.Count; i++)
        {
            float CD = ennemys[i].GetComponent<EnnemyScript>().GetSpawnWaveCD(wave);
            ennemysCDWave[i] = CD;
        }

        interWave = false;
        //ShowingWaveNumber(wave, waveNumber, WaveNumberText);
        SpawnTrophys(parentTrophys);
        Debug.Log(wave);
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

        for (int x = 0; x < trophysParent.transform.childCount; x++)
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
