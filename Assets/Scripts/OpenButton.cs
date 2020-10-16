using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OpenButton : MonoBehaviour
{
    //public Button openButton;

    public GameObject door;

    public AudioMixer mixer;
    public AudioSource sourceDoor1;
    public AudioSource sourceDoor2;

    Vector3 previous;

    int n = 0;

    public void openDoor()
    {
        
        if (n == 0)
        {
            previous = door.transform.localScale;
            door.transform.localScale = new Vector3(1, 1, 1);
            sourceDoor1.Play();
            n++;             
        }
        else
        {
            door.transform.localScale = previous;
            sourceDoor2.Play();
            n--;           
        }
    }
}
