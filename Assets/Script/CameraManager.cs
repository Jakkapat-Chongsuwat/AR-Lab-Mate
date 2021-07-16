using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject cam; //input camera

    // Start is called before the first frame update
    void Start()
    {
        cam.SetActive(true); //Start camera at 1st scene.
        
    }

    public void OnClick()
    {
        if (cam.activeSelf == true) //if cam is on >>> off
            cam.SetActive(false);
        else
            cam.SetActive(true); //if cam is off >>> on

    }
  
}
