using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// In case of adding UI - not finished.

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;

    void Start()
    {

    }

    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}
