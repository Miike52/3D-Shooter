using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WoodDamage : MonoBehaviour
{
    [SerializeField] AudioSource woodHitAudioSource;
    [SerializeField] AudioSource woodBreakAudioSource;
    public float maxHealth = 100f;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        woodHitAudioSource.Play();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        woodBreakAudioSource.Play();
        Destroy(gameObject);
    }
}
