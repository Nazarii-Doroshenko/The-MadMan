using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowPanel : MonoBehaviour
{
    public GameObject Panel;
    int n = 0;

    public void OpenPanel()
    {
        if (n == 0)
        {
            Panel.SetActive(true);
            n++;
        }
        else
        {
            Panel.SetActive(false);
            n--;
        }
        
    }
    public void OnlyOpen()
    {
        Panel.SetActive(true);
    }
    public void ClosePanel()
    {         
        Panel.SetActive(false);
    }
}
