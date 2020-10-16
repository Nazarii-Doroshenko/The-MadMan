using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.Advertisements.Utilities;
using UnityEngine.Monetization;


public class Ads : MonoBehaviour
{
    public bool isTestMode = true;

    public static int adCount = 0;
    public int p;
    string adID_video = "video";
    string adID_rewardedVideo = "rewardedVideo";
    string adID_banner = "banner";

    void Start()
    {
        //check bought or no
        if (Advertisement.isSupported)
        {
            if( Application.platform == RuntimePlatform.IPhonePlayer) { Advertisement.Initialize("3705230", isTestMode);  } 
            else if(Application.platform == RuntimePlatform.Android) { Advertisement.Initialize("3705231", isTestMode);  }
            Advertisement.Initialize("3705231", isTestMode);
            AdBanner();
        }
    }
    void Update()
    {
        
    }
    public void ShowVideoAd()
    {

    }
    public void RewardedAd()
    {
        if (Advertisement.IsReady(adID_rewardedVideo))
        {
            Advertisement.Show(adID_rewardedVideo);
        }
        AdFinished();
    }
    public void AdBanner()
    {
        StartCoroutine(ShowBannerWhenInitialized());
        if(p == 0)
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        if(p == 1)
            Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
        if (p == 2)
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_LEFT);
        if (p == 3)
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_RIGHT);

    }
    IEnumerator ShowBannerWhenInitialized()
    {
        while (!Advertisement.isInitialized)
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show("banner");
        
    }
    /*IEnumerator WaitForAd(bool reward = false)
    {
        string placementId = reward ? adID_rewardedVideo : adID_video;
        while (!Advertisement.IsReady(placementId))
        {
            yield return null;
        }
        ShowAdPlacementContent ad = null;
        ad = Advertisement.GetPlacementContent(placementId) as ShowAdPlacementContent;
        if(ad != null)
        {
            if (reward)
                ad.Show(AdFinished);
            else
                ad.Show();
        }
    }*/
    public void AdFinished()
    {
        
            int c;
            c = PlayerPrefs.GetInt("money");
            c++;
            PlayerPrefs.SetInt("money", c);
            PlayerPrefs.Save();
        
    }   
}
