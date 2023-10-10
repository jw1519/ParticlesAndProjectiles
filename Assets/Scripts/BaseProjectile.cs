using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProjectile : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 3f;
    
    public void Initialize(Vector3 direction, Vector3 upward)
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        if (rigidbody != null)
        {
            //set the forward velocity
            Vector3 forwardVelocity = direction * speed;

            //Add upward velocity for an arc
            Vector3 upwardVelocity = upward * speed * 0.5f;

            //combine velocities
            Vector3 initialVelocity = forwardVelocity + upwardVelocity;

            rigidbody.velocity = initialVelocity;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
