using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleDuplicater : MonoBehaviour
{
    //Number of the elements to instantiate
    public int numObjects = 20;
    //Element to instantiate 
    public Transform bubbleGenerator;

    //The column to be surrounded
    public GameObject center;
    //How far from the column
    private float distFromColumn = 0.0001f;
    //How many elements generated
    private int generatedElementsCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Asign the column gameobject
        center = GameObject.Find("Packed Column Effect container");
        CreateElements();

    }


    public void CreateElements()
    {
        for (int i = 0; i < numObjects; i++)
        {
            generatedElementsCount++;
            string ObjectName = "Element_" + generatedElementsCount;
            float angleIteration = 360 / numObjects;
            float currentRotation = angleIteration * i;

            //Create object as transform
            Transform elem;
            elem = Instantiate(bubbleGenerator, center.transform.position, center.transform.rotation) as Transform;

            elem.name = ObjectName;

            elem.transform.Rotate(new Vector3(140, 0, currentRotation));
            elem.transform.Translate(new Vector3(distFromColumn, 0.01f));
            elem.gameObject.tag = "Generated Bubble";
        }
    }

}

