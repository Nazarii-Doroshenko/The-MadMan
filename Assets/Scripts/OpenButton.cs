using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenButton : MonoBehaviour
{
    public Button openButton;
    public GameObject door;
    Vector3 previous;
    int n = 0;
    public void openDoor()
    {
        if (n == 0)
        {
            previous = door.transform.localScale;
            door.transform.localScale = new Vector3(1, 1, 1);
            
            n++; 
        }
        else
        {
            door.transform.localScale = previous;
            n--;
        }
    }
}
