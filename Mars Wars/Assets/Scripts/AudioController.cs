using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider SliderSound;
    public AudioSource musicSource;
    public AudioSource efectsSource;
    public Slider SliderEffects;

   
    void Start()
    {
        musicSource.volume = SliderSound.value;
        //O SliderSoundMofied()
        musicSource.pitch = SliderEffects.value;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Valor modificado" + SliderSound.value);
        Debug.Log("Valor modificado" + SliderEffects.value);
    }

    public void SliderSoundMofied()
    {
        Debug.Log("Valor modificado" + SliderSound.value);

        //El volumen = slider sound value
        musicSource.volume = SliderSound.value;
    }

    //Crear una función que al modificar el valor del slider de brillo/pitch cambia el pitch en el audio source

    public void SliderEffectsMofied()
    {
        Debug.Log("Valor modificado" + SliderEffects.value);

        //El pitch = slider sound value
        musicSource.pitch = SliderEffects.value;
    }
}
