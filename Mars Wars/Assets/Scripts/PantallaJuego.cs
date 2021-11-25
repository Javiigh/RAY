using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantallaJuego : MonoBehaviour
{

    public GameObject Marte1p;
    public GameObject Starship1p;
    public GameObject Marte2p;
    public GameObject Starship2p;
    public GameObject Starship2p2;
    public Button P1B;
    public Button P2B;
    public GameObject Selected1p;
    public GameObject Selected2p;
    public GameObject NonSelected1p;
    public GameObject NonSelected2p;
    public GameObject P1Jugador;
    public GameObject P1Jugador2;
    public GameObject P2Jugadores;
    public GameObject P2Jugadores2;
    public GameObject Modojuego;

    void Start()
    {
        
    }

    void Update()
    {
       
    }

    public void ClickP1B()
    {
        Marte1p.SetActive(true);
        Starship1p.SetActive(true);
        Marte2p.SetActive(false);
        Starship2p.SetActive(false);
        Starship2p2.SetActive(false);
        Modojuego.SetActive(false);

        //Botones

        Selected1p.SetActive(true);
        NonSelected1p.SetActive(false);
        NonSelected2p.SetActive(true);
        Selected2p.SetActive(false);

        //Texto

        P1Jugador.SetActive(true);
        P1Jugador2.SetActive(true);
        P2Jugadores.SetActive(false);
        P2Jugadores2.SetActive(false);
}

    public void ClickP2B()
    {
        Marte1p.SetActive(false);
        Starship1p.SetActive(false);
        Marte2p.SetActive(true);
        Starship2p.SetActive(true);
        Starship2p2.SetActive(true);
        Modojuego.SetActive(false);


        //Botones

        Selected1p.SetActive(false);
        NonSelected1p.SetActive(true);
        NonSelected2p.SetActive(false);
        Selected2p.SetActive(true);

        //Texto

        P1Jugador.SetActive(false);
        P1Jugador2.SetActive(false);
        P2Jugadores.SetActive(true);
        P2Jugadores2.SetActive(true);
    }
}
