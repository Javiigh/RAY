using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButton : MonoBehaviour
{
    public Button SelectedButton;

    void OnEnable()
    {
        SelectedButton.Select();
    }

}


//PUBLIC AudioSource effect;




//[Dentro de la función] effect.Play();
