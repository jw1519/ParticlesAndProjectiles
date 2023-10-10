using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffectProjectile : BaseProjectile
{
    public GameObject particleEffect;

        private void OnCollisionEnter(Collision collision)
    {
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
