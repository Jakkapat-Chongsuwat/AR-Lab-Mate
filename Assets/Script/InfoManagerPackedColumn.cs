using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoManagerPackedColumn : MonoBehaviour
{
    //Menu states
    public enum InfoStates { Column1, Column2, Column3 };
    public InfoStates currentstate;

    public GameObject Column1info;
    public GameObject Column2info;
    public GameObject Column3info;
   

    //Game Object


    //When script is first started.
    void Awake()
    {
        //Always set first menu to the main menu
        currentstate = InfoStates.Column1;
    }

    void Update()
    {
        //Check current menu state.
        switch (currentstate)
        {
            case InfoStates.Column1:

                //Sets active game object for main menu
                Column1info.SetActive(true);
                Column2info.SetActive(false);
                Column3info.SetActive(false);
            
                break;

            case InfoStates.Column2:

                //Sets active game object for info
                Column1info.SetActive(false);
                Column2info.SetActive(true);
                Column3info.SetActive(false);

                break;

            case InfoStates.Column3:

                //Sets active game object for obj
                Column1info.SetActive(false);
                Column2info.SetActive(false);
                Column3info.SetActive(true);
   
                break;
           
        }
    }

    //When Menu Button is pressed.
    public void OnColumn1()
    {
        Debug.Log("You pressed Column1");
        //Add load level for new scene here.
        currentstate = InfoStates.Column1;
    }

    //When info button is pressed.
    public void OnColumn2()
    {
        Debug.Log("you pressed Column2");

        //Change menu state
        currentstate = InfoStates.Column2;
    }
    public void OnColumn3()
    {
        Debug.Log("you pressed Column3");

        //Change menu state
        currentstate = InfoStates.Column3;
    }
 
    
}
