using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuShips : MonoBehaviour
{
    public Button Jugar;
    public Button UnJugador;
    public Button Jugadores;
    public GameObject SiJuega;
    public GameObject NoJuega;
    public GameObject EleccionNave;
    public GameObject EleccionJuego;
    public AudioSource efectsSource; 
    public AudioSource ShipMusic;
    public AudioSource Music;
    public AudioSource ButtonSound;

    void Start()
    {
        Jugar.enabled= false;
    }

    void Update()
    {
   
    }

    public void ClickUnJugador()
    {
        SiJuega.SetActive(true);
        NoJuega.SetActive(false);
        Jugar.enabled = true;
        ButtonSound.Play(0);
    }

    public void ClickJugadores()
    {
        SiJuega.SetActive(true);
        NoJuega.SetActive(false);
        Jugar.enabled = true;
        ButtonSound.Play(0);
    }

    public void ClickJugar()
    {
        EleccionNave.SetActive(true);
        EleccionJuego.SetActive(false);
        efectsSource.Play(0);
        ShipMusic.Play(0);
        Music.Pause();
        ButtonSound.Play(0);
    }
}
