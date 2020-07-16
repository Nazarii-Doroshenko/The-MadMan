using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SliderScript : MonoBehaviour
{
    public Slider sliderD;
    public Slider sliderP;
    public Slider sliderUI;
    public Slider sliderBG;

    public AudioMixer mixer;

    void Start()
    {
        sliderD.value = PlayerPrefs.GetFloat("DAudioMixer", 1);
        sliderP.value = PlayerPrefs.GetFloat("PAudioMixer", 1);
        sliderUI.value = PlayerPrefs.GetFloat("UIAudioMixer", 1);
        sliderBG.value = PlayerPrefs.GetFloat("BGAudioMixer", 1);
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
}
