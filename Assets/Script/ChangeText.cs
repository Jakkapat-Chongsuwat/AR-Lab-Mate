using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
   public Text Textfield; //Text Variable

   public void SetText(string text)
   {
       Textfield.text = text;
   }
  
    
}
