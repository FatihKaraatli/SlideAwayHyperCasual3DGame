using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsAndOptions : MonoBehaviour
{
    public GameObject options;
    public GameObject shop;
    public GameObject soundOn;
    public GameObject soundOff;
    
    public GameObject vibrationOn;
    public GameObject vibrationOff;

    public AudioSource slowMotionAudio;

    void Start()
    {
        if (PlayerPrefs.GetString("sound") == "on")
        {
            SoundOffButton();
        }
        else if (PlayerPrefs.GetString("sound") == "off")
        {
            SoundOnButton();
        }

        if (PlayerPrefs.GetString("vibrationbutton") == "on")
        {
            VibrationOffButton();
        }
        else if (PlayerPrefs.GetString("vibrationbutton") == "off")
        {
            VibrationOnButton();
        }
    }

    public void OptionsButton()
    {
        options.SetActive(true);
    }

    public void ShopButton()
    {
        shop.SetActive(true);
        options.SetActive(false);
    }

    public void SoundOnButton()
    {
        PlayerPrefs.SetString("sound","off");
        soundOn.SetActive(false);
        soundOff.SetActive(true);
        slowMotionAudio.volume = 0f;
    }

    public void SoundOffButton()
    {
        PlayerPrefs.SetString("sound", "on");
        soundOff.SetActive(false);
        soundOn.SetActive(true);
        slowMotionAudio.volume = 0.1f;
    }

    public void VibrationOnButton()
    {
        PlayerPrefs.SetString("vibrationbutton", "off");
        vibrationOff.SetActive(true);
        vibrationOn.SetActive(false);
    }
    public void VibrationOffButton()
    {
        PlayerPrefs.SetString("vibrationbutton","on");
        vibrationOff.SetActive(false);
        vibrationOn.SetActive(true);
    }

    public void CloseOptionsButton()
    {
        options.SetActive(false);
    }


}
