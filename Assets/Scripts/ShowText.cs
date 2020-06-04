using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ShowText : MonoBehaviour
{
    public Button button;
    public Text text;

    public void showText(string s)
    {
        text.text = s;

    }

}
