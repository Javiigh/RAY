using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarshipShipController : MonoBehaviour
{
    float speed;
    float ColissionSpeed;

    public SpaceshipScreen s;

    void Start()
    {
        speed = -0.005f;
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
