using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcularVelocidad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float CalcularVelocidad (float espacioRecorrido, float tiempoNecesario)
        {
            float Velocidad = espacioRecorrido / tiempoNecesario;
            return Velocidad;
        }

        float Velocidad = CalcularVelocidad(100, 9.4f);
        Debug.Log("La velocidad es de" + CalcularVelocidad(50,2.5f) + "m/s");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
