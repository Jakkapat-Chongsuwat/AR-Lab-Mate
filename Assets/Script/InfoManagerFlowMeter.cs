using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManagerFlowMeter : MonoBehaviour
{
    //Menu states
    public enum InfoStates { Info1, Info2, Info3, Info4 };
    public InfoStates currentstate;

    public GameObject Info1info;
    public GameObject Info2info;
    public GameObject Info3info;
    public GameObject Info4info;

    //Game Object


    //When script is first started.
    void Awake()
    {
        //Always set first menu to the main menu
        currentstate = InfoStates.Info1;
    }

    void Update()
    {
        //Check current menu state.
        switch (currentstate)
        {
            case InfoStates.Info1:

                //Sets active game object for main menu
                Info1info.SetActive(true);
                Info2info.SetActive(false);
                Info3info.SetActive(false);
                Info4info.SetActive(false);
                break;

            case InfoStates.Info2:

                //Sets active game object for info
                Info1info.SetActive(false);
                Info2info.SetActive(true);
                Info3info.SetActive(false);
                Info4info.SetActive(false);
                break;

            case InfoStates.Info3:

                //Sets active game object for obj
                Info1info.SetActive(false);
                Info2info.SetActive(false);
                Info3info.SetActive(true);
                Info4info.SetActive(false);
                break;
            case InfoStates.Info4:

                //Sets active game object for obj
                Info1info.SetActive(false);
                Info2info.SetActive(false);
                Info3info.SetActive(false);
                Info4info.SetActive(true);
                break;
        }
    }

    //When Menu Button is pressed.
    public void OnInfo1()
    {
        Debug.Log("You pressed Info1");
        //Add load level for new scene here.
        currentstate = InfoStates.Info1;
    }

    //When info button is pressed.
    public void OnInfo2()
    {
        Debug.Log("you pressed Info2");

        //Change menu state
        currentstate = InfoStates.Info2;
    }
    public void OnInfo3()
    {
        Debug.Log("you pressed Info3");

        //Change menu state
        currentstate = InfoStates.Info3;
    }
    public void OnInfo4()
    {
        Debug.Log("you pressed Info4");

        //Change menu state
        currentstate = InfoStates.Info4;
    }

}
