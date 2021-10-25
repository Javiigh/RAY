using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour
{
    public GameObject PantallaEspera;
    public GameObject PantallaInicial;
    public GameObject JugarB;
    public GameObject OpcionesB;
    public GameObject RecordsB;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ClickJugarButton()
    {
        PantallaInicial(false);
        Juego.SetActive(true);
    }
}
