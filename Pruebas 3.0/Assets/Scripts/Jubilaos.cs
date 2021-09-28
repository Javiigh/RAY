using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jubilaos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int edad = 20;

        if (edad > 60)
        {
            Debug.Log("Está jubilado");
        }

        else if (edad > 18)
        {
            Debug.Log("Puede votar");
        }

        else
        {
            Debug.Log("Puede trabajar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
