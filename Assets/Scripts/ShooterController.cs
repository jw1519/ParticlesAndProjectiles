using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject simpleProjectilePrefab;
    public GameObject clusterProjectilePrefab;
    public GameObject particleProjectilePrefab;
    public Transform shootPoint; 
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Shoot(simpleProjectilePrefab);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Shoot(clusterProjectilePrefab);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Shoot(particleProjectilePrefab);
        }
    }

    private void Shoot(GameObject projectilePrefab)
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation); 
        BaseProjectile baseProjectile = projectile.GetComponent<BaseProjectile>();
        if (baseProjectile != null)
        {
            baseProjectile.Initialize(shootPoint.forward, shootPoint.up); 
        }
    }
}
