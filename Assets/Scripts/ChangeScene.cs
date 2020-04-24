using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Button finish;
    

    public void NextLvl()
    {
        SceneManager.LoadScene("LVL2");        
    }


}
