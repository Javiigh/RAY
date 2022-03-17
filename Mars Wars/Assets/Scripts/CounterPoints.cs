using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterPoints : MonoBehaviour
{
    float Points = 0f;
    int PointsV = 0;
    int PointsR = 0;
    int PointsA = 0;
    public TextMeshProUGUI PointsText;

    public GameObject FinalScreen;
    public Button SigScreen;

    void Start()
    {
        PointsText.text = "Puntos = " + Points;
    }

    void Update()
    {
        //Debug.Log(Points);
    }

    public void PuntoVerde()
    {
        PointsV = 0;
        PointsV++;
        SumaPuntos();
        Debug.Log("PV" + PointsV);
    }

    public void PuntoRojo()
    {
        PointsR = 0;
        PointsR++;
        Debug.Log("Pr");
    }

    public void PuntoAzul()
    {
        PointsA = 0;
        PointsA++;
        Debug.Log("Pa");
    }

    public void SumaPuntos()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            sumar();
        }
        if (PointsV >= 1)
        {
            sumar();
            Debug.Log("Sumado1");
        }
        if (PointsR >= 1)
        {
            sumar();
            sumar();
        }
        if (PointsR >= 1)
        {
            sumar();
            sumar();
            sumar();
        }
    }

    void sumar()
    {
        Points = Points + 1.0f;
        Debug.Log("Sumado2"); 
        Debug.Log("Por qué no funciona :(");
    }

    public void ClickSigScreen()
    {
        FinalScreen.SetActive(true);
    }
}
