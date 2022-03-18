using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScreen : MonoBehaviour
{
    public Button Replay;
    public TextMeshProUGUI Score;
    public CounterPoints counterPoints;

    void Start()
    {
        Score.text = "Puntos = " + counterPoints.Points;
    }

    void Update()
    {
        
    }

    public void ClickReplay()
    {
        
    }
}
