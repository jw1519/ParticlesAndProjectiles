using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClusterProjectile : BaseProjectile
{
    public GameObject childProjectile;
    public int numberOfChildren = 3;

    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < numberOfChildren; i ++)
        {
            Instantiate(childProjectile, transform.position, Quaternion.Euler(0, i * (360 / numberOfChildren), 0));
        }
        Destroy(gameObject);
    }



}
