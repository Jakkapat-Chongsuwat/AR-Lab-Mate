using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterlevelController : MonoBehaviour
{
    private Renderer water;
    public Dropdown waterLevelValue;
    public Dropdown airLevelValue;
    private float waterLevel;
    private float airLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        waterLevel = 1;
        water = GetComponent<Renderer>();
        water.material.SetFloat("_Cutoff",waterLevel);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //    if (Input.GetKeyDown(KeyCode.Return))
    //    {
    //        waterLevel = float.Parse(waterLevelValue.text);
    //        water.material.SetFloat("_Cutoff",waterLevel);
    //    }
    //}

    //void WaterLevelRatio ()
    //{
    //    waterLevel = float.Parse(waterLevelValue.text);
    //    airLevel = float.Parse(airLevelValue.text);
    //    if (waterLevel == 2.5)
    //    {
    //        if (airLevel >= 20 && airLevel < 70)
    //        {
                
    //        }

    //    }
    //}
}
