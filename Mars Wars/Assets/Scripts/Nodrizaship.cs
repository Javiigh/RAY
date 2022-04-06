using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodrizaship : MonoBehaviour
{
    public float NodrizaTimer = 0;
    Rigidbody2D rigidbody2D;
    float Speed = 0.005f;
    float Speed2;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        NodrizaTimer = NodrizaTimer + Time.deltaTime;

        if ( NodrizaTimer > 5)
        {
            firstMovimiento();
        }
        
        if (transform.position.magnitude > 15.0f)
        {
            Speed = -Speed;
        }
    }

    void firstMovimiento()
    {
        transform.Translate(-Speed, 0, 0);
        //NodrizaTimer = 0;
    }
}
