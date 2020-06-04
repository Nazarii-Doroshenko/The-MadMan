using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OpenButton : MonoBehaviour
{
    public Button openButton;

    public GameObject door;

    public AudioMixer mixer;
    public AudioSource source;

    Vector3 previous;

    int n = 0;

    public void openDoor()
    {
        if (n == 0)
        {
            previous = door.transform.localScale;
            door.transform.localScale = new Vector3(1, 1, 1);
            source.Play();
            n++;             
        }
        else
        {
            door.transform.localScale = previous;
            source.Play();
            n--;           
        }
    }  
}
