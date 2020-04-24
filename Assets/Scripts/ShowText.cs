using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public Button button;
    public Text text;
    public string displayingtext;

    public void showText(string s)
    {
        text.text = s;

    }

}
