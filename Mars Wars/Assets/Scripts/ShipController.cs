using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RazorController : MonoBehaviour
{
    float speed;
    float ColissionSpeed;

    //public GameObject Nave;
    void Start()
    {
        speed = 0.009f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localPosition.x > 9)
            {
                ColissionSpeed = 0;
            }
            else
            {
                ColissionSpeed = speed;
            }

            transform.Translate(ColissionSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.localPosition.x < -9)
            {
                ColissionSpeed = 0;
            }
            else
            {
                ColissionSpeed = speed;
            }

            transform.Translate(-ColissionSpeed, 0, 0);
        }
    }
}
