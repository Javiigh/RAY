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
    }

    public void ClickJugadores()
    {
        SiJuega.SetActive(true);
        NoJuega.SetActive(false);
        Jugar.enabled = true;
    }

    public void ClickJugar()
    {
        EleccionNave.SetActive(true);
        EleccionJuego.SetActive(false);
    }
}
