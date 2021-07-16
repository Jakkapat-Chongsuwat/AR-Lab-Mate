using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignAlpha : MonoBehaviour
{
    // create list of component (in case many object)
    public float NewAlpha; 

    // Reference ChangeAlpha script
    private ChangeAlpha changeAlpha;

    void Awake ()
    {
        // Get component from another script
        changeAlpha = GetComponent<ChangeAlpha> ();
    }
    // Start is called before the first frame update
    void Start()
    {
        //Change alpha cutoff
        changeAlpha.alpha = NewAlpha;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick()
    {
        changeAlpha.alpha = NewAlpha;
    }
}
