using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldCheck : MonoBehaviour
{
    public InputField inp;
    public GameObject o;
    public string text;
    public void CheckTheText()
    {
        if(text == inp.text) 
        {
            o.SetActive(true);
        }
        
    }
}
