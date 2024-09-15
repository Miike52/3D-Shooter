using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WeaponSwitcher : MonoBehaviour
{
    public GameObject uzi;
    public GameObject shotgun;
    public GameObject rpg;
    public GameObject currentWeapon;

    private int currentWeaponIndex = 0;

    private void Start()
    {
        SetActiveWeapon(currentWeaponIndex);
    }

    private void Update()
    {
        if (Keyboard.current[Key.Digit1].wasPressedThisFrame)
        {
            SwitchWeapon(0); // Uzi
        }
        else if (Keyboard.current[Key.Digit2].wasPressedThisFrame)
        {
            SwitchWeapon(1); // Shotgun
        }
        else if (Keyboard.current[Key.Digit3].wasPressedThisFrame)
        {
            SwitchWeapon(2); // RPG
        }
    }

    public void SwitchWeapon(int newWeaponIndex)
    {
        SetActiveWeapon(currentWeaponIndex, false);

        currentWeaponIndex = newWeaponIndex;

        SetActiveWeapon(currentWeaponIndex, true);
    }


    public void SetActiveWeapon(int weaponIndex, bool isActive = true)
    {
        uzi.SetActive(false);
        shotgun.SetActive(false);
        rpg.SetActive(false);

        if (weaponIndex == 0)
        {
            uzi.SetActive(isActive);
            currentWeapon = uzi;
        }
        else if (weaponIndex == 1)
        {
            shotgun.SetActive(isActive);
            currentWeapon = shotgun;
        }
        else if (weaponIndex == 2)
        {
            rpg.SetActive(isActive);
            currentWeapon = rpg;
        }
    }
}
