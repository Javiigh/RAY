using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float movSpeed = 2f;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        //transform.position += Vector3.right * Time.deltaTime;

        //transform.Translate(Vector3.right * Time.deltaTime);

        //si pulsass W moverlo arriba y resto de controles.

        Vector3 myMov = Vector3.zero;
        

        if (Input.GetKeyDown(KeyCode.W))
        {
            myMov += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            myMov += Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            myMov += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            myMov += Vector3.right;
        }

        transform.Translate(myMov.normalized * Time.deltaTime * movSpeed);
    }
}
