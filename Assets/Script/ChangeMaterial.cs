using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial  : MonoBehaviour
{
    public Material[] materials; //Allows input of material colors in a set size of array
    public Renderer Rend; // Input object to render

    private int index = 1;

    // Start is called before the first frame update
    void Start(){
        Rend = GetComponent<Renderer> ();//Give functionality for the renderer
        Rend.enabled = true;  //Make the rendered 3d object visible if enable
    }
    void OnMouseDown()
    {
        if (materials.Length ==0) //If there are no materials nothing happen.
            return;

        if (Input.GetMouseButtonDown (0)){
            index += 1;//When mouse is down we increment to the next index location

            if (index == materials.Length + 1) //When it reach the ed of the material, it start over
                index = 1;

            print(index); // for debugging

            Rend.sharedMaterial = materials [index-1]; //This sets the material value inside the index
        }
    }
    public void ButtonPressed()
    {
        if (materials.Length == 0)
        return; //If there are no material nothing happens.

        if (index == materials.Length + 1) // Start over when end the cycle.
        index = 1;

        print (index); //for debugging

        Rend.sharedMaterial = materials [index - 1]; //This sets the material color values inside the index
    }
    
}
