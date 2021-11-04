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

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PantallaEspera.SetActive(false);
            PantallaInicial.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PantallaEspera.SetActive(false);
            Juego.SetActive(false);
            Opciones.SetActive(false);
            Records.SetActive(false);
            PantallaInicial.SetActive(true);
        }
    }

    public void ClickJugarB()
    {
        PantallaInicial.SetActive(false);
        Juego.SetActive(true);
    }

    public void ClickOpcionesB()
    {
        PantallaInicial.SetActive(false);
        Opciones.SetActive(true);
    }

    public void ClickRecordsB()
    {
        PantallaInicial.SetActive(false);
        Records.SetActive(true);
    }
}
