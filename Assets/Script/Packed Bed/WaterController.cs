using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterController : MonoBehaviour
{
    public InputField water1;
    private float water1_Value;
    public Renderer packedColumn1;
    public float alpha = 0;
    // Start is called before the first frame update
    void Start()
    {
        packedColumn1 = GetComponent<Renderer>();
        packedColumn1.material.SetFloat ("_Cutoff", alpha);
        Debug.Log("alpha cutoff has changed");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetWaterLevel ()
    {
        water1_Value = float.Parse(water1.text);
        packedColumn1.material.SetFloat ("_Cutoff", water1_Value);
        Debug.Log("new alpha cutoff has been entered");
    } 
}
