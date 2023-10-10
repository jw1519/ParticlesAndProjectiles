using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Particle
{
    public GameObject gameObject;
    public Vector3 velocity;
    public float lifespan;
    public float age;

    public Particle (GameObject gameObject, float lifespan, Vector3 velocity)
    {
        this.gameObject = gameObject;
        this.velocity = velocity;
        this.lifespan = lifespan;
        age = 0;
    }

    // Update is called once per frame
    public void Update(float deltaTime)
    {
        age += deltaTime;
        if (age >= lifespan)
        {
            age = 0;
        }
        else
        {
            //update position based on velocity
            gameObject.transform.position += velocity * deltaTime;
        }
        
    }
}
