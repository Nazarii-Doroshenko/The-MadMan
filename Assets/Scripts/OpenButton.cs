using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenButton : MonoBehaviour
{
    public Button openButton;
    public GameObject door;

    int n = 0;
    public void openDoor()
    {
        if (n == 0)
        {
            
            door.transform.localScale = new Vector3(1, 1, 1);
            
            n++; 
        }
        else
        {
            door.transform.localScale = new Vector3(1, 10, 20);
            n--;
        }
    }
}
