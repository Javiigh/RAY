using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigMove : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float speedMov = 2;
    float EjeXSpeed;
    float EjeYSpeed;
    public int choque;
    float timer;
    float timerY;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        //Debug.Log(choque);
        //Debug.Log(timer);
        //Debug.Log(timerY);
        timer = timer + Time.deltaTime;
        timerY = timerY + Time.deltaTime;

        if (timer > 2)
        {
            movXD();
        }

        if (timerY > 5)
        {
            movY();
        }

        if (Input.GetKey(KeyCode.F))
        {
            movXD();
        }

        if (Input.GetKey(KeyCode.I))
        {
            movY();
        }
    }

    void movXD()
    {
        EjeXSpeed = speedMov;
        timer = 0;

        if (choque > 0)
        {
            transform.Translate(-EjeXSpeed, 0, 0);
        }
        else
        {
            transform.Translate(EjeXSpeed, 0, 0);
        }

    }

    void movY()
    {
        EjeYSpeed = speedMov / 10;

        transform.Translate(0, -EjeYSpeed, 0);

        timerY = 0;
    }

    public void ColisionD()
    {
        choque++;
    }

    public void ColisionI()
    {
        choque--;
    }
}
