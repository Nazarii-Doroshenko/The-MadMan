using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioScript : MonoBehaviour
{
    public Slider slider;
    public GameObject mute;
    public GameObject unMute;

    public AudioMixer mixer;

    float k;
    int nS = 0;
    int nI = 0;
    int nM = 0;
    public string param;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat(param, 1);
    }
    public void DoorsVolume(float value)
    {
        mixer.SetFloat("DAudioMixer", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("DAudioMixer", value);
        PlayerPrefs.Save();
    }
    public void PortalsVolume(float value)
    {
        mixer.SetFloat("PAudioMixer", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("PAudioMixer", value);
        PlayerPrefs.Save();
    }
    public void UIVolume(float value)
    {
        mixer.SetFloat("UIAudioMixer", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("UIAudioMixer", value);
        PlayerPrefs.Save();
    }
    public void BGVolume(float value)
    {
        mixer.SetFloat("BGAudioMixer", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("BGAudioMixer", value);
        PlayerPrefs.Save();
    }
    public void SliderValue(Slider s)
    {
        k = slider.value;
        if (nS == 0)
        {  
            s.SetValueWithoutNotify(0);
            nS++;
        }
        else
        {
            s.SetValueWithoutNotify(k);
            nS--;
        }
        
    }  
    public void ImageChange()
    {
        if (nI == 0)
        {
            mute.SetActive(true);
            unMute.SetActive(false);
            nI++;
        }
        else
        {
            mute.SetActive(false);
            unMute.SetActive(true);
            nI--;
        }
    }
    public void MixerVol()
    {
        k = slider.value;
        if(nM == 0)
        {

            mixer.SetFloat(param, 0);
            PlayerPrefs.SetFloat(param, 0);
            PlayerPrefs.Save();
            nM++;
        }
        else
        {
            mixer.SetFloat(param, k);
            PlayerPrefs.SetFloat(param, k);
            PlayerPrefs.Save();
            nM--;
        }
    }
}
        
    
