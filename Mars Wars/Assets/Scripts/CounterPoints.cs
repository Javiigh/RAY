using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterPoints : MonoBehaviour
{
    public int Points = 0;

    public GameObject FinalScreen;
    public ShipController shipController;
    public static CounterPoints instance;
    public TextMeshProUGUI PointsText;

    void Awake()
    {
        if (CounterPoints.instance == null)
        {
            CounterPoints.instance = this;
            PointsText.text = "Puntos = " + Points;
        }
        else
        {
            Destroy(this);
        }
       
    }

    void Update()
    {
        //Debug.Log(Points);
    }

    public void SumaPuntos(int amount)
    {
        Points += amount;
        PointsText.text = "Puntos = " + Points;
    }
}
