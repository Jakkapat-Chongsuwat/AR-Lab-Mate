using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour
{
    public float delay = 0.1f;
    public Transform spawnObject;
    public GameObject obj;

    void Start(){
        InvokeRepeating("Spawn",delay,delay);

    }
    void Spawn (){
        Quaternion spawnrotation = Quaternion.Euler(0,0,0);
        Instantiate (obj,spawnObject.position, spawnrotation);
    }

}