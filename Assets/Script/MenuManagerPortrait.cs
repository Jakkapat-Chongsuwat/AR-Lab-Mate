using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManagerPortrait : MonoBehaviour    
{
    //Menu states
    public enum MenuStates {MainMenu, info, Obj, Howto, Theory, Cal};
    public MenuStates currentstate;

    public GameObject mainMenu;
    public GameObject infoMenu;
    public GameObject objMenu;
    public GameObject howtoMenu;
    public GameObject theoryMenu;
    public GameObject calMenu;

    //Game Object


    //When script is first started.
    void Awake()
    {
        //Always set first menu to the main menu
        currentstate = MenuStates.MainMenu;
    }

    void Update()
    {
        //Check current menu state.
        switch (currentstate)
        {
            case MenuStates.MainMenu:

                //Sets active game object for main menu
                mainMenu.SetActive(true);
                infoMenu.SetActive(false);
                objMenu.SetActive(false);
                howtoMenu.SetActive(false);
                theoryMenu.SetActive(false);
                calMenu.SetActive(false);
                break;     

            case MenuStates.info:

                //Sets active game object for info
                mainMenu.SetActive(false);
                infoMenu.SetActive(true);
                objMenu.SetActive(false);
                howtoMenu.SetActive(false);
                theoryMenu.SetActive(false);
                calMenu.SetActive(false);
                break;     
            case MenuStates.Obj:

                //Sets active game object for obj
                mainMenu.SetActive(false);
                infoMenu.SetActive(false);
                objMenu.SetActive(true);
                howtoMenu.SetActive(false);
                theoryMenu.SetActive(false);
                calMenu.SetActive(false);
                break;  

            case MenuStates.Howto:

                //Sets active game object for Howto
                mainMenu.SetActive(false);
                infoMenu.SetActive(false);
                objMenu.SetActive(false);
                howtoMenu.SetActive(true);
                theoryMenu.SetActive(false);
                calMenu.SetActive(false);
                break;     

            case MenuStates.Theory:

                //Sets active game object for Theory
                mainMenu.SetActive(false);
                infoMenu.SetActive(false);
                objMenu.SetActive(false);
                howtoMenu.SetActive(false);
                theoryMenu.SetActive(true);
                calMenu.SetActive(false);
                break;      
            case MenuStates.Cal:

                //Sets active game object for Theory
                mainMenu.SetActive(false);
                infoMenu.SetActive(false);
                objMenu.SetActive(false);
                howtoMenu.SetActive(false);
                theoryMenu.SetActive(false);
                calMenu.SetActive(true);
                break;     
        }
    }

    //When Menu Button is pressed.
    public void OnMainMenu()
    {
        Debug.Log("You pressed menu:");
        //Add load level for new scene here.
        currentstate = MenuStates.MainMenu;
    }

    //When info button is pressed.
    public void Oninfo()
    {
        Debug.Log("you pressed info.");

        //Change menu state
        currentstate = MenuStates.info;
    }
    public void OnObj()
    {
        Debug.Log("you pressed Obj.");

        //Change menu state
        currentstate = MenuStates.Obj;
    }
    public void OnHowto()
    {
        Debug.Log("you pressed how to.");

        //Change menu state
        currentstate = MenuStates.Howto;
    }
    public void OnTheory()
    {
        Debug.Log("you pressed theory.");

        //Change menu state
        currentstate = MenuStates.Theory;
    }
    public void OnBack()
    {
        Debug.Log("you pressed back, go back to main menu.");

        //Change menu state
        currentstate = MenuStates.MainMenu;
    }
    public void OnCal()
    {
        Debug.Log("you pressed cal, go back to cal menu.");

        //Change menu state
        currentstate = MenuStates.Cal;
    }
}
