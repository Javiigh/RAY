using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public Slider SliderSound;
    public AudioSource musicSource;
    public Slider SliderPitch;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.volume = SliderSound.value;
        //O SliderSoundMofied()
        musicSource.pitch = SliderPitch.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SliderSoundMofied()
    {
        Debug.Log("Valor modificado" + SliderSound.value);

        //El volumen = slider sound value
        musicSource.volume = SliderSound.value;
    }

    //Crear una función que al modificar el valor del slider de brillo/pitch cambia el pitch en el audio source

    public void SliderPitchMofied()
    {
        Debug.Log("Valor modificado" + SliderPitch.value);

        //El volumen = slider sound value
        musicSource.pitch = SliderPitch.value;
    }
}
