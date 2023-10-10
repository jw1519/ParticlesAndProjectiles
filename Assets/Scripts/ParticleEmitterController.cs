
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEmitter : MonoBehaviour
{
    public GameObject particlePrefab;
    public int maxParticles = 100;
    public float particleLifespan = 1.0f;
    public float speed = 10.0f;

    private List<Particle> particles = new List<Particle>();

    // Start is called before the first frame update
    void Start()
    {
        //spawn all particles at once
        for (int i = 0; i < maxParticles; i++)
        {
            SpawnParticle();
        }
    }

    private void SpawnParticle()
    {
        //generate random direction
        Vector3 randomDirection = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
            ).normalized;
        GameObject gameObject = Instantiate(particlePrefab, transform.position, Quaternion.identity);
        Particle newParticle = new Particle(gameObject, particleLifespan, randomDirection * speed);
        particles.Add(newParticle);
    }

    // Update is called once per frame
    void Update()
    {
        //update existing particles
        for(int i = particles.Count - 1; i >=0; i--)
        {
            Particle particle = particles[i];
            particle.Update(Time.deltaTime);

            if(particle.age <= 0)
            {
                Destroy(particle.gameObject);
                particles.RemoveAt(i);
            }
        }
        if(particles.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
