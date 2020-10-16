using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customize : MonoBehaviour
{
    public GameObject col;
    public int color = 3;
    //public Material mat;
    void Start()
    {
        
       // PlayerPrefs.SetInt("colorOfPlayer", "magenta");
        color = PlayerPrefs.GetInt("colorOfPlayer");
        Mat();
    }
    public void Mat()
    {
        if(color == 1)
        {
            RedMat();
        }
        if (color == 2)
        {
            BlueMat();
        }
        if (color == 3)
        {
            WhiteMat();
        }
        if (color == 4)
        {
            YellowMat();
        }
        if (color == 5)
        {
            MagentaMat();
        }
        if (color == 6)
        {
            GreenMat();
        }
        
    }
    public void RedMat()
    {
        col.GetComponent<Renderer>().material.color = Color.red;
        color = 1;
        PlayerPrefs.SetInt("colorOfPlayer", color);
    }
    public void BlueMat()
    {
        col.GetComponent<Renderer>().material.color = Color.blue;
        color = 2;
        PlayerPrefs.SetInt("colorOfPlayer", color);
    }
    public void WhiteMat()
    {
        col.GetComponent<Renderer>().material.color = Color.white;
        color = 3;
        PlayerPrefs.SetInt("colorOfPlayer", color);
    }
    public void YellowMat()
    {
        col.GetComponent<Renderer>().material.color = Color.yellow;
        color = 4;
        PlayerPrefs.SetInt("colorOfPlayer", color);
    }
    public void MagentaMat()
    {
        col.GetComponent<Renderer>().material.color = Color.magenta;
        color = 5;
        PlayerPrefs.SetInt("colorOfPlayer", color);
    }
    public void GreenMat()
    {
        col.GetComponent<Renderer>().material.color = Color.green;
        color = 6;
        PlayerPrefs.SetInt("colorOfPlayer", color);
    }
}
