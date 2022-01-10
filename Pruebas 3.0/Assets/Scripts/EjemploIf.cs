using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploIf : MonoBehaviour
{

    public Material materialRojo;
    public Material materialAzul;
    public MeshRenderer render;

    float contador = 0.0f;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
        render.material = materialRojo;
    }

    void Update()
    {
        contador += Time.deltaTime;

        Debug.Log(contador);

        if (contador >= 5f)

           render.material = materialAzul;
    }
}
