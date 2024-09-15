using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage; // message displayed to the Player when looking at an interactable - not finished.

    public void BaseInteract()
    {
        Interact(); // function called from our Player script - not finished.
    }
    
    protected virtual void Interact()
    {
        // template function to be overridden by our subclasses - not finished.
    }

}
