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
    public Button JugarB;
    public GameObject OpcionesB;
    public GameObject RecordsB;

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
    }

    public void ClickJugarB()
    {
        PantallaInicial.SetActive(false);
        Juego.SetActive(true);
    }

}
