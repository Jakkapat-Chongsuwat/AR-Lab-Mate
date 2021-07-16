using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwitchManager : MonoBehaviour 
 {
 
public GameObject[] objects;
public int activeIndex = 0;
 
 public void SetActiveObject(int aIndex)
 {
     activeIndex = aIndex;
     for(int i = 0; i < objects.Length; i++)
         objects[i].SetActive(i == activeIndex);
 }
 
 void Update()
 {
     SetActiveObject(activeIndex);
 }
 }