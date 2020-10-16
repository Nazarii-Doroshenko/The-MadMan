using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public int c;
    //int co;
    public Text coins;
    public int k = 0;
    public GameObject text;
    public GameObject skip;
    public GameObject button;


    void Start()
    {
       
        //PlayerPrefs.DeleteAll();
        c = PlayerPrefs.GetInt("money");
        
        coins.text = c.ToString();

    }
    public void Buy(int n)
    {
        if (c > 0)
        {
            
            c -= n;
            coins.text = c.ToString();
            PlayerPrefs.SetInt("money", c);
            PlayerPrefs.Save();
        }
        
        
    }
    void Update()
    {
        c = PlayerPrefs.GetInt("money");
        coins.text = c.ToString();
    }
    public void ShowBuyText(int n)
    {
        
        if ( c > 0 )
        {
            text.SetActive(true);
            c -= n;
            coins.text = c.ToString();
            PlayerPrefs.SetInt("money", c);
            PlayerPrefs.Save();
        }
    }
    public void SkipLvlBuy(int n)
    {
        if ( c > 0 && c-n >=0 )
        {
            skip.SetActive(true);
            c -= n;
            coins.text = c.ToString();
            PlayerPrefs.SetInt( "money", c );
            PlayerPrefs.Save();
        }
    }
    public void AddCoins(int n)
    {

        c += n;
        coins.text = c.ToString();
        PlayerPrefs.SetInt( "money", c );
        PlayerPrefs.Save();
        if( k == 1 )
        {
            button.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if( k == 0 )
        {
            c++;
            coins.text = c.ToString();
            PlayerPrefs.SetInt("money", c);
            PlayerPrefs.Save();
        }
        if( k == 1 )
        {
            button.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if( k == 1 )
        {
            button.SetActive(false);
        }
    }

    //сделать так чтоб монетка пропадала


}
