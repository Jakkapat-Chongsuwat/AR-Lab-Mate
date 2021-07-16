using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManagerTheory : MonoBehaviour    
{
    //Menu states
    public enum MenuStates {Theory0,EnergyBalance};
    public MenuStates currentstate;

    public List<GameObject> EnergyBalanceComponent = new List<GameObject>();

    //When script is first started.
    void Awake()
    {
        //Set all button to unselected.
        GameObject myEventSystem = GameObject.Find("EventSystem");
        myEventSystem .GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);

        //Always set first menu to the main menu
        currentstate = MenuStates.Theory0;
    }

    void Update()
    {
        //Check current menu state.
        switch (currentstate)
        {
            case MenuStates.Theory0:

                //Sets active game object for null theory
                
                for( int i = 0; i < EnergyBalanceComponent.Count; i++)
                    EnergyBalanceComponent[i].SetActive(false);

                break;

            case MenuStates.EnergyBalance:

                //Sets active game object for energy balance
                for( int i = 0; i < EnergyBalanceComponent.Count; i++)
                    EnergyBalanceComponent[i].SetActive(true);
                break;

        }
    }

    //When Menu Button is pressed.
    public void OnEnergyBalance()
    {
        Debug.Log("You pressed menu:");
        //Add load level for new scene here.
        currentstate = MenuStates.EnergyBalance;
    }

    
}
