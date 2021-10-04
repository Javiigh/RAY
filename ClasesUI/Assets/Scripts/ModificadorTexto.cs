using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModificadorTexto : MonoBehaviour
{
    public TextMeshProUGUI textLabelPoints;
    private int points = 0;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        textLabelPoints.text = "Puntos = " + points;
    }

    // Update is called once per frame
    void Update()
    {
        textLabelPoints.text = "Puntos = " + points;
        textLabelPoints.text = "Tiempo " + time;

        //Cuando toque espacio aumente en 10 la cantidad de puntos.
        if (Input.GetKeyUp(KeyCode.Space))
        {
            points = points + 10;
        }

        Debug.Log("Puntos = " + points);

        if (Input.GetKey(KeyCode.Space))
        {
            time += Time.deltaTime;
        }
    }
}