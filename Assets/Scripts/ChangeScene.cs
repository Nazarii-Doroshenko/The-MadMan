using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public float playerMinPosX = 567;
    public float playerMinPosY = 19;
    public float playerMinPosZ = 667;
    public float playerMaxPosX = 611;
    public float playerMaxPosY = 20;
    public float playerMaxPosZ = 628;

    public Button finish;

    public GameObject player;

    public void Labyrinth_Lvl_2()
    {
        SceneManager.LoadScene("Labyrinth_LVL2");        
    }
    public void Labyrinth_Lvl_3()
    {
        bool CanMinX = player.transform.position.x >= playerMinPosX;
        bool CanMinY = player.transform.position.y >= playerMinPosY;
        bool CanMinZ = player.transform.position.z >= playerMinPosZ;

        bool CanMaxX = player.transform.position.x <= playerMaxPosX;
        bool CanMaxY = player.transform.position.y <= playerMaxPosY;
        bool CanMaxZ = player.transform.position.z <= playerMaxPosZ;

        if ( CanMinX && CanMinY && CanMinZ && CanMaxX && CanMaxY && CanMaxZ )
        {
            SceneManager.LoadScene("Labyrinth_LVL3");
        }
        
    }
    void FixedUpdate()
    {
        Labyrinth_Lvl_3();
    }
}
