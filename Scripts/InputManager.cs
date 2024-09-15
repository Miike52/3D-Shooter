using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class InputManager : MonoBehaviour
{
    public PlayerInput.OnFootActions onFoot;
    
    private PlayerInput.OnFootActions Jump;
    private PlayerInput playerInput;
    private PlayerMotor motor;
    private PlayerLook look;
    private WeaponSystem weapon;
    private WeaponSwitcher weaponSwitcher;

    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();
        weapon = GetComponent<WeaponSystem>(); 
        weaponSwitcher = GetComponent<WeaponSwitcher>();

        onFoot.Jump.performed += ctx => motor.Jump();
        onFoot.Crouch.performed += ctx => motor.Crouch();
        onFoot.Sprint.performed += ctx => motor.Sprint();
        onFoot.Fire.performed += ctx => Shoot();
    }

    void FixedUpdate()
    {
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());
    }

    private void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        onFoot.Enable();
    }
    private void OnDisable()
    {
        onFoot.Disable();
    }

    private void Shoot()
    {
        if (weapon != null)
        {
            weapon.Shoot();
        }
    }
}
