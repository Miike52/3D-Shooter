using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// In case of adding keypad/door logic - not finished.

public class Keypad : Interactable // inherits from Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;

    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("IsOpen", doorOpen); 
    }

}
