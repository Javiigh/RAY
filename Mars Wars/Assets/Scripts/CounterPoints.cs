using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterPoints : MonoBehaviour
{
    public int Points = 0;

    public ShipController shipController;
    public static CounterPoints instance;
    public TextMeshProUGUI PointsText;
    public GameObject FinalScreenPrefab;

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
        if (Points >= 410)
        {
            Win();
        }
    }

    public void SumaPuntos(int amount)
    {
        Points += amount;
        PointsText.text = "Puntos = " + Points.ToString();
    }

    public void Win()
    {
        GameObject Screen = Instantiate(FinalScreenPrefab, new Vector2(0, 0), Quaternion.identity);
    }
}
