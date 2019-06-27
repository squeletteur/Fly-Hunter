using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbalete : MonoBehaviour {

    [SerializeField]
    private Transform[] firePoints;
    [SerializeField]
    private Rigidbody projectilePrefab;
    [SerializeField]
    private float launchForce = 700f;
    public Transform projectileTransform;

    public bool fire;
    public int ammo = 30;
    private Animator anim;
    public GameObject chargeur;
    public GameObject cartouche;
    public Transform chargeurSpawn;
    public Transform cartoucheSpawn;
    public bool vide = false;
    public float vitesse = 2;

    public GameObject effet;

    float timer = 0;
    public float MaxTime = 10f;

    public AudioSource fireSound;
    public AudioSource outSound;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = vitesse;
    }

    // Update is called once per frame
    void Update()
    {
        if(fire)
        {
            
            LaunchProjectile();
            fire = false;
            //InvokeRepeating("LaunchProjectile",0f, 0.5f);
            
        }

        if(ammo <= 0 && vide == false)
        {
           
            anim.SetBool("outAmmo", true);
            outSound.Play();
            Instantiate(chargeur, chargeurSpawn.position, chargeurSpawn.rotation);
            vide = true;
        }

        if(ammo <= 0)
        {
            timer += Time.deltaTime;

            if (timer >= MaxTime)
            {
                Destroy(gameObject);
                return;
            }
        }
    }

    


    public void LaunchProjectile()
    {
        if(ammo >= 0)
        {
            anim.SetTrigger("fire");
            fireSound.Play();
            Instantiate(cartouche, cartoucheSpawn.position, cartoucheSpawn.rotation);

            foreach (var firePoint in firePoints)
            {
                var projectileInstance = Instantiate(projectilePrefab, firePoint.position, projectileTransform.rotation);

                //Instantiate(effet, firePoint.position, projectileTransform.rotation);
                ammo--;
                
                //,firePoint.rotation

                projectileInstance.AddForce(firePoint.forward * -launchForce);
            }
        }
        
    }
}
