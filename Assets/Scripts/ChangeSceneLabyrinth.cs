using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSceneLabyrinth : MonoBehaviour
{
    public float sceneNum;
    public Button finish;
    
    public GameObject player;

    public void Labyrinth_Lvl_1()
    {
        SceneManager.LoadScene("Labyrinth_LVL1_Tutorial");
    }
    public void Labyrinth_Lvl_2()
    {
            SceneManager.LoadScene("Labyrinth_LVL2_Tutorial");        
    }
    public void Labyrinth_Lvl_3()
    {       
            SceneManager.LoadScene("Labyrinth_LVL3_Tutorial");       
    }
    public void Labyrinth_Lvl_4()
    {        
            SceneManager.LoadScene("Labyrinth_LVL4_Tutorial");       
    }
    public void Labyrinth_Lvl_5()
    {
        SceneManager.LoadScene("Labyrinth_LVL5_Tutorial");
    }
    public void Labyrinth_Lvl_6()
    {
        SceneManager.LoadScene("Labyrinth_LVL6_Volcano");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (sceneNum == 3)
        {
            Labyrinth_Lvl_3();
        }
        if (sceneNum == 4)
        {
            Labyrinth_Lvl_4();
        }
        if (sceneNum == 5)
        {
            Labyrinth_Lvl_5();
        }
        if (sceneNum == 6)
        {
            Labyrinth_Lvl_6();
        }
    }
    
}
