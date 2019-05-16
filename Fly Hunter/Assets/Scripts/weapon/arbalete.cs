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

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(fire)
        {
            LaunchProjectile();
            fire = false;
        }
    }




    public void LaunchProjectile()
    {
        foreach (var firePoint in firePoints)
        {
            var projectileInstance = Instantiate(projectilePrefab, firePoint.position, projectileTransform.rotation);

            //,firePoint.rotation

            projectileInstance.AddForce(firePoint.forward * -launchForce);
        }
    }
}
