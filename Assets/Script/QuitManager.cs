using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Quits

public class QuitManager : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnClick()
    {
    // Quit when click
        Application.Quit();
        Debug.Log("You pressed Quit.");
    }
}
