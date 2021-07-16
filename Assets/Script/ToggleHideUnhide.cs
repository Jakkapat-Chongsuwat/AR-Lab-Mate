using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHideUnhide : MonoBehaviour{

    public void Start()
    {
        gameObject.SetActive(false);
    }

    private void ToggleVisibility()
    {
        gameObject.SetActive(true);
        Renderer rend = gameObject.GetComponent<Renderer>();

        if (rend.enabled)
            rend.enabled = false;
        else
            rend.enabled = true;
    }
}
