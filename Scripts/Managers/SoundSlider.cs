using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    public Slider sfxslider;
    public Slider bgmslider;

    public static bool check = false;

    private void Awake()
    {
        if (!check)
        {
            PlayerPrefs.SetFloat("BGMVolume", 1);
            PlayerPrefs.SetFloat("SFXVolume", 1);

            check = true;
        }


        sfxslider.value = PlayerPrefs.GetFloat("SFXVolume");
        bgmslider.value = PlayerPrefs.GetFloat("BGMVolume");


    }

    public void OptionExit()
    {
        Time.timeScale = 1;
    }

}
