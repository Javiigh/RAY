using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodrizaship : MonoBehaviour
{
    public float NodrizaTimer = 0;
    public float NodrizaMove = 0;
    Rigidbody2D rigidbody2D;
    float Speed = 2;
    float Speed2;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        NodrizaTimer = NodrizaTimer + Time.deltaTime;
        NodrizaMove = NodrizaMove + Time.deltaTime;

        if ( NodrizaTimer > 5)
        {
            firstMovimiento();
        }
        
        if(NodrizaMove > 6)
        {
            movimiento();
        }

        if (transform.position.magnitude > 12.0f)
        {
            Speed = -Speed;
        }
    }

    void firstMovimiento()
    {
        transform.Translate(-Speed, 0, 0);
        NodrizaTimer = 0;
    }

    void movimiento()
    {
        Speed2 = Speed / 2;
         transform.Translate(-Speed2, 0, 0);
         NodrizaMove = 0;
    }
}
