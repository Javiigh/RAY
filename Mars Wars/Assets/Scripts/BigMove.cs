using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigMove : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    float speedMov = 2;
    float EjeXSpeed;
    public int choque;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            movXD();
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("col");
        choque++;

        if (other.gameObject.tag == "Laterales")
        {
            EjeXSpeed = -EjeXSpeed;
        }

        else
        {

        }

    }

    void movXD()
    {
        EjeXSpeed = speedMov / 10;

        if (choque == 1)
        {
            transform.Translate(-EjeXSpeed, 0, 0);
        }
        else
        {
            transform.Translate(EjeXSpeed, 0, 0);
        }

    }
}
