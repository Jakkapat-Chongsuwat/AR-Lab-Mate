using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> deactivate_Screen = new List<GameObject>(); 

    void Start()
    {
        for( int i = 0; i < deactivate_Screen.Count; i++)
        {
            deactivate_Screen[i].SetActive(false);
        }
    }

    public void OnClick()
    {        
        for( int i = 0; i < deactivate_Screen.Count; i++)
        {
            if (deactivate_Screen[i].activeSelf == false)
            deactivate_Screen[i].SetActive(true);

            else
            deactivate_Screen[i].SetActive(false);
        }
    }
}
