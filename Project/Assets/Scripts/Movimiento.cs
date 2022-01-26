using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float movSpeed = 10f;
    public float forceJump = 3f;
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
        

        if (Input.GetKey(KeyCode.W))
        {
            myMov += Vector3.up * forceJump;
        }
        if (Input.GetKey(KeyCode.S))
        {
            myMov += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            myMov += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            myMov += Vector3.right;
        }

        transform.Translate(myMov * Time.deltaTime * movSpeed, Space.World);
    }
}
