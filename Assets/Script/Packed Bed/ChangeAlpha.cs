using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAlpha : MonoBehaviour
{
    public float alpha = 1 ;
    // Start is called before the first frame update
    void Start()
    {
        ChangeAlphaCutOff ();
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the Return key is pressed down
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GetComponent<Renderer>().material.SetFloat ("_Cutoff", alpha);
            Debug.Log("Return key was pressed.");
        }

        if (Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("Return key was released.");
        }
    }

    public void ChangeAlphaCutOff ()
    {
        //Set up the material
        // GetComponent<Renderer>().material.SetOverrideTag("RenderType", "AlphaCutout");
        // GetComponent<Renderer>().material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.One);
        // GetComponent<Renderer>().material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.Zero);
        // GetComponent<Renderer>().material.SetInt("_ZWrite", 1);
        // GetComponent<Renderer>().material.EnableKeyword("_ALPHATEST_ON");
        // GetComponent<Renderer>().material.DisableKeyword("_ALPHABLEND_ON");
        // GetComponent<Renderer>().material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
        // GetComponent<Renderer>().material.renderQueue = 2450;

        //Set new Alpha cutoff
        GetComponent<Renderer>().material.SetFloat ("_Cutoff", alpha);
        
            
    }
}
