using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManager2 : MonoBehaviour    
{
    //Menu states
    public enum MenuStates {MainMenu, info, Obj, Howto, Theory, Cal};
    public MenuStates currentstate;

    public List<GameObject> mainComponent = new List<GameObject>(); 
    public List<GameObject> infoComponent = new List<GameObject>(); 
    public List<GameObject> objComponent = new List<GameObject>(); 
    public List<GameObject> howtoComponent = new List<GameObject>(); 
    public List<GameObject> theoryComponent = new List<GameObject>();
    public List<GameObject> calComponent = new List<GameObject>();

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
                
                for( int i = 0; i < mainComponent.Count; i++)
                    mainComponent[i].SetActive(true);

                for( int i = 0; i < infoComponent.Count; i++)
                    infoComponent[i].SetActive(false);
                
                for( int i = 0; i < objComponent.Count; i++)
                    objComponent[i].SetActive(false);
                
                for( int i = 0; i < howtoComponent.Count; i++)
                    howtoComponent[i].SetActive(false);
                
                for( int i = 0; i < theoryComponent.Count; i++)
                    theoryComponent[i].SetActive(false);

                for (int i = 0; i < calComponent.Count; i++)
                    calComponent[i].SetActive(false);
                break;

            case MenuStates.info:

                //Sets active game object for info
                for( int i = 0; i < mainComponent.Count; i++)
                    mainComponent[i].SetActive(false);

                for( int i = 0; i < infoComponent.Count; i++)
                    infoComponent[i].SetActive(true);
                
                for( int i = 0; i < objComponent.Count; i++)
                    objComponent[i].SetActive(false);
                
                for( int i = 0; i < howtoComponent.Count; i++)
                    howtoComponent[i].SetActive(false);
                
                for( int i = 0; i < theoryComponent.Count; i++)
                    theoryComponent[i].SetActive(false);

                for (int i = 0; i < calComponent.Count; i++)
                    calComponent[i].SetActive(false);
                break;
            case MenuStates.Obj:

                //Sets active game object for obj
                for( int i = 0; i < mainComponent.Count; i++)
                    mainComponent[i].SetActive(false);

                for( int i = 0; i < infoComponent.Count; i++)
                    infoComponent[i].SetActive(false);
                
                for( int i = 0; i < objComponent.Count; i++)
                    objComponent[i].SetActive(true);
                
                for( int i = 0; i < howtoComponent.Count; i++)
                    howtoComponent[i].SetActive(false);
                
                for( int i = 0; i < theoryComponent.Count; i++)
                    theoryComponent[i].SetActive(false);

                for (int i = 0; i < calComponent.Count; i++)
                    calComponent[i].SetActive(false);
                break;
            case MenuStates.Howto:

                //Sets active game object for Howto
                for( int i = 0; i < mainComponent.Count; i++)
                    mainComponent[i].SetActive(false);

                for( int i = 0; i < infoComponent.Count; i++)
                    infoComponent[i].SetActive(false);
                
                for( int i = 0; i < objComponent.Count; i++)
                    objComponent[i].SetActive(false);
                
                for( int i = 0; i < howtoComponent.Count; i++)
                    howtoComponent[i].SetActive(true);
                
                for( int i = 0; i < theoryComponent.Count; i++)
                    theoryComponent[i].SetActive(false);

                for (int i = 0; i < calComponent.Count; i++)
                    calComponent[i].SetActive(false);
                break;  
            case MenuStates.Theory:

                //Sets active game object for Theory
                for( int i = 0; i < mainComponent.Count; i++)
                    mainComponent[i].SetActive(false);

                for( int i = 0; i < infoComponent.Count; i++)
                    infoComponent[i].SetActive(false);
                
                for( int i = 0; i < objComponent.Count; i++)
                    objComponent[i].SetActive(false);
                
                for( int i = 0; i < howtoComponent.Count; i++)
                    howtoComponent[i].SetActive(false);
                
                for( int i = 0; i < theoryComponent.Count; i++)
                    theoryComponent[i].SetActive(true);

                for (int i = 0; i < calComponent.Count; i++)
                    calComponent[i].SetActive(false);
                break;
            case MenuStates.Cal:

                //Sets active game object for Theory
                for (int i = 0; i < mainComponent.Count; i++)
                    mainComponent[i].SetActive(false);

                for (int i = 0; i < infoComponent.Count; i++)
                    infoComponent[i].SetActive(false);

                for (int i = 0; i < objComponent.Count; i++)
                    objComponent[i].SetActive(false);

                for (int i = 0; i < howtoComponent.Count; i++)
                    howtoComponent[i].SetActive(false);

                for (int i = 0; i < theoryComponent.Count; i++)
                    theoryComponent[i].SetActive(false);

                for (int i = 0; i < calComponent.Count; i++)
                    calComponent[i].SetActive(true);
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
    public void OnCal()
    {
        Debug.Log("you pressed cal.");

        //Change menu state
        currentstate = MenuStates.Cal;
    }
        public void OnBack()
    {
        Debug.Log("you pressed back, go back to main menu.");

        //Change menu state
        currentstate = MenuStates.MainMenu;
    }
}
