using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlMenu : MonoBehaviour
{
    public GameObject PantallaEspera;
    public GameObject PantallaInicial;
    public GameObject Juego;
    public GameObject Opciones;
    public GameObject Records;
    public Button JugarB;
    public Button OpcionesB;
    public Button RecordsB;
    public AudioSource efectsSource;
    public AudioSource ButtonSound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            PantallaEspera.SetActive(false);
            PantallaInicial.SetActive(true);
            efectsSource.Play(0);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PantallaEspera.SetActive(false);
            Juego.SetActive(false);
            Opciones.SetActive(false);
            Records.SetActive(false);
            PantallaInicial.SetActive(true);
            efectsSource.Play(0);
        }
    }

    public void ClickJugarB()
    {
        PantallaInicial.SetActive(false);
        Juego.SetActive(true);
        efectsSource.Play(0);
        ButtonSound.Play(0);
    }

    public void ClickOpcionesB()
    {
        PantallaEspera.SetActive(false);
        PantallaInicial.SetActive(false);
        Opciones.SetActive(true);
        efectsSource.Play(0);
        ButtonSound.Play(0);
    }

    public void ClickRecordsB()
    {
        PantallaInicial.SetActive(false);
        Records.SetActive(true);
        efectsSource.Play(0);
        ButtonSound.Play(0);
    }

    public void VolverPantallaInicial()
    {
        PantallaInicial.SetActive(true);
        Opciones.SetActive(false);
        efectsSource.Play(0);
        ButtonSound.Play(0);
    }
}
