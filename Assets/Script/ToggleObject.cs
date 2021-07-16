using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour{

    public void Start()
    {
        gameObject.SetActive(false);
    }

    void ToggleVisibility()
    {
        gameObject.SetActive(true);
        
    }
}
