using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palas : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;

    float speed;
    float ColissionSpeed;

    void Start()
    {
        speed = 0.009f;
    }

    void Update()
    {
        if(Input.GetKey(up))
        {
           if(transform.localPosition.y > 5)
            {
                ColissionSpeed = 0;
            }
            else
            {
                ColissionSpeed = speed;
            }
            transform.Translate(0, ColissionSpeed, 0);
        }

        if (Input.GetKey(down))
        {
            if (transform.localPosition.y < -3)
            {
                ColissionSpeed = 0;
            }
            else
            {
                ColissionSpeed = speed;
            }
            transform.Translate(0, -ColissionSpeed, 0);
        }

    }
}
