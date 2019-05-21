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

            
        }

        if(ammo <= 0 && vide == false)
        {
           
            anim.SetBool("outAmmo", true);
            Instantiate(chargeur, chargeurSpawn.position, chargeurSpawn.rotation);
            vide = true;
        }
    }

    




    public void LaunchProjectile()
    {
        if(ammo >= 0)
        {
            anim.SetTrigger("fire");
            Instantiate(cartouche, cartoucheSpawn.position, cartoucheSpawn.rotation);

            foreach (var firePoint in firePoints)
            {
                var projectileInstance = Instantiate(projectilePrefab, firePoint.position, projectileTransform.rotation);
                ammo--;
                
                //,firePoint.rotation

                projectileInstance.AddForce(firePoint.forward * -launchForce);
            }
        }
        
    }
}
