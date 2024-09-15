using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public ParticleSystem destructionParticles;

    private void OnDestroy()
    {
        PlayDestructionParticles();
    }

    private void PlayDestructionParticles()
    {
        if (destructionParticles != null)
        {
            ParticleSystem particles = Instantiate(destructionParticles, transform.position, transform.rotation);
            particles.Play();
        }
    }
}
