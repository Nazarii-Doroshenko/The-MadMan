using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UDP;

public class ChangeMenuScenes : MonoBehaviour
{
    //public AudioSource source;
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void GameMenu()
    {
        SceneManager.LoadScene("Game Menu");
    }
    public void LabyrinthMenu()
    {
        SceneManager.LoadScene("Labyrinth Menu");
    }
    public void MathsMenu()
    {
        SceneManager.LoadScene("Maths menu");
    }
    public void SettingsMenu()
    {
        SceneManager.LoadScene("Settings Menu");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void Quit()
    {
        Application.Quit();
    }
    
    
}
