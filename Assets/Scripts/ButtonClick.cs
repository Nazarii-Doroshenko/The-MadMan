using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public AudioSource source;
    public void ButtonClickOn()
    {
        source.Play();
    }
}
