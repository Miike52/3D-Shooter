using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSystem : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletUziPrefab;
    public GameObject bulletShotgunPrefab;
    public GameObject bulletRpgPrefab;
    public AudioSource bulletUziShotSFX;
    public AudioSource bulletShotgunShotSFX;
    public AudioSource bulletRpgShotSFX;

    public float fireRate = 0.5f;
    public float bulletSpeed = 10f;
    public float bulletDamage = 10f;
    private float nextFireTime = 0f; // not finished

    private WeaponSwitcher weaponSwitcher;

    private InputAction shootAction;

    private void Awake()
    {

        weaponSwitcher = GetComponent<WeaponSwitcher>();

        shootAction = new InputAction(binding: "*/<Fire>");
        shootAction.performed += ctx => Shoot();
        shootAction.Enable();
    }

    private void Update()
    {
        // in case of handling other shooting-related logic - not finished.
    }

    public void Shoot()
    {
        if (weaponSwitcher.currentWeapon.name == "Uzi" && bulletUziPrefab != null && firePoint != null)
        {

            bulletUziShotSFX.Play();
            GameObject bullet = Instantiate(bulletUziPrefab, firePoint.position, firePoint.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = bullet.transform.forward * bulletSpeed;

        }

        if (weaponSwitcher.currentWeapon.name == "Shotgun" && bulletShotgunPrefab != null && firePoint != null)
        {
            bulletShotgunShotSFX.Play();
            GameObject bullet = Instantiate(bulletShotgunPrefab, firePoint.position, firePoint.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = bullet.transform.forward * bulletSpeed;
        }

        if (weaponSwitcher.currentWeapon.name == "RPG" && bulletRpgPrefab != null && firePoint != null)
        {
            bulletRpgShotSFX.Play();
            GameObject bullet = Instantiate(bulletRpgPrefab, firePoint.position, firePoint.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = bullet.transform.forward * bulletSpeed;
        }
    }

    private void OnDestroy()
    {
        shootAction.Disable();
    }
}
