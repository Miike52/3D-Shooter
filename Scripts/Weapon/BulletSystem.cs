using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour
{
    public float bulletDamage = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        string collidedTag = collision.collider.tag;

        if (collidedTag != null)
        {
            if (collidedTag == "WoodWeak") // may add another collided tag, comparing if the specific Weapon can damage the specific Material etc.
            {
                ApplyWeakWoodDamage(collision);
            }
            else if (collidedTag == "Wood")
            {
                ApplyWoodDamage(collision);
            }

            else if (collidedTag == "MetalWeak")
            {
                ApplyMetalDamage(collision);
            }
            else if (collidedTag == "MetalStrong")
            {
                ApplyStrongMetalDamage(collision);
            }
            else
            {
                ApplyDefaultDamage();
            }
        }

        Destroy(gameObject);
    }

    private void ApplyWeakWoodDamage(Collision collision)
    {
        if (collision.gameObject.CompareTag("WoodWeak"))
        {
            float adjustedDamage = bulletDamage * 3f;

            WoodDamage woodScript = collision.gameObject.GetComponent<WoodDamage>();
            if (woodScript != null)
            {
                woodScript.TakeDamage(adjustedDamage);
            }
        }
    }

    private void ApplyWoodDamage(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wood"))
        {
            float adjustedDamage = bulletDamage * 1.5f;

            WoodDamage woodScript = collision.gameObject.GetComponent<WoodDamage>();
            if (woodScript != null)
            {
                woodScript.TakeDamage(adjustedDamage);
            }
        }
    }

    private void ApplyMetalDamage(Collision collision)
    {
        if (collision.gameObject.CompareTag("MetalWeak"))
        {
            float adjustedDamage = bulletDamage * 2f;

            MetalDamage metalScript = collision.gameObject.GetComponent<MetalDamage>();
            if (metalScript != null)
            {
                metalScript.TakeDamage(adjustedDamage);
            }
        }
    }

    private void ApplyStrongMetalDamage(Collision collision)
    {
        if (collision.gameObject.CompareTag("MetalStrong"))
        {
            float adjustedDamage = bulletDamage * 1f;

            MetalDamage metalScript = collision.gameObject.GetComponent<MetalDamage>();
            if (metalScript != null)
            {
                metalScript.TakeDamage(adjustedDamage);
            }
        }
    }

    private void ApplyDefaultDamage()
    {
        // not finished
    }
}
