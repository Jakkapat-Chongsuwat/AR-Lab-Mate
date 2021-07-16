using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOrientationManager : MonoBehaviour
{
    public GameObject canvasPortrait;
    public GameObject canvasLandscape;

    void Start()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait)
        canvasLandscape.SetActive(false);
        canvasPortrait.SetActive(true);

        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
        canvasLandscape.SetActive(true);
        canvasPortrait.SetActive(false);

        if (Screen.orientation == ScreenOrientation.Portrait)
        canvasLandscape.SetActive(false);
        canvasPortrait.SetActive(true);

       if (Screen.orientation == ScreenOrientation.LandscapeLeft)
        canvasLandscape.SetActive(false);
        canvasPortrait.SetActive(true);
    }

    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait)
        canvasLandscape.SetActive(false);
        canvasPortrait.SetActive(true);

        if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
        canvasLandscape.SetActive(true);
        canvasPortrait.SetActive(false);

         if (Screen.orientation == ScreenOrientation.Portrait)
        canvasLandscape.SetActive(false);
        canvasPortrait.SetActive(true);

       if (Screen.orientation == ScreenOrientation.LandscapeLeft)
        canvasLandscape.SetActive(false);
        canvasPortrait.SetActive(true);
    }
}
