using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int sceneNum;
    public Button finish;
    
    public GameObject player;

    public void Labyrinth_Lvl_2()
    {
            SceneManager.LoadScene("Labyrinth_LVL2");        
    }
    public void Labyrinth_Lvl_3()
    {       
            SceneManager.LoadScene("Labyrinth_LVL3");       
    }
    public void Labyrinth_Lvl_4()
    {        
            SceneManager.LoadScene("Labyrinth_LVL4");       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(sceneNum == 3)
        {
            Labyrinth_Lvl_3();
        }
        if (sceneNum == 4)
        {
            Labyrinth_Lvl_4();
        }
    }
    
}
