using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MetalDamage : MonoBehaviour
{
    [SerializeField] AudioSource metalHitAudioSource;
    [SerializeField] AudioSource metalBreakAudioSource;
    public float maxHealth = 100f;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        metalHitAudioSource.Play();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        metalBreakAudioSource.Play();
        Destroy(gameObject);
    }
}
