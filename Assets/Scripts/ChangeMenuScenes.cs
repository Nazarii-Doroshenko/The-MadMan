using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Audio;
using UnityEngine.SceneManagement;
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
    public void SettingsMenu()
    {
        SceneManager.LoadScene("Settings Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
