using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class HowtoManager : MonoBehaviour
{

    public List<GameObject> Steps; // <<<<<<<<<<<<  Drag all Steps here

    public int stepindex;

    public void Next()
    {

        if (stepindex == Steps.Count)
        {
            stepindex = 0;
            Debug.Log(stepindex);
            Debug.Log("Next when i=size");
        }

        for (int i = 0; i < Steps.Count; i++)
        { // This cycles (iterates) through OnShow (IsOn script) list

            Steps[i].SetActive(false);

        }

        if (Steps.Count > 0)
        {

            Steps[stepindex].SetActive(true);
            stepindex++;
            Debug.Log(stepindex);
            Debug.Log("Next");

        }
    }
    public void Previous()
    {
        if (stepindex < 0)
        {
            stepindex = Steps.Count;
            Debug.Log(stepindex);
            Debug.Log("Previous when i=0");
        }


        for (int i = 0; i < Steps.Count; i++)
        { 

            Steps[i].SetActive(false);
            
        }

        if (Steps.Count > 0)
        {
            stepindex--;
            Steps[stepindex].SetActive(true);
            
            Debug.Log(stepindex);
            Debug.Log("Previous");

        }
    }
}
