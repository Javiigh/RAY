using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Config : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;

    void OnEnable()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume", 1.0f);
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume", 1.0f);
    }

    public void SalirSinGuardar()
    {
        //O no hacer nada
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume", 1.0f);
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume", 1.0f);
    }

    public void GuardarDatos()
    {
        PlayerPrefs.SetFloat("sfxVolume" , sfxSlider.value);
        PlayerPrefs.SetFloat("musicVolume" , musicSlider.value);
        PlayerPrefs.Save();
    }

}
