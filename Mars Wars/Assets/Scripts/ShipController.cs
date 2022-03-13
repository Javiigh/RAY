using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    float speed;
    float ColissionSpeed;

    public SpaceshipScreen s;
    public int ship;

    void Start()
    {
       
    }

    void Update()
    {
        s = FindObjectOfType<SpaceshipScreen>();
        Debug.Log("s.ship " + s.Ship);
        Debug.Log(speed);
        Debug.Log("ship" + ship);

        ship = s.Ship;

        if (s.Ship == 0)
        {
            speed = -0.005f;
        }
        else if (s.Ship == 1)
        {
            speed = 0.002f;
        }

        else
        {
            speed = 0.009f;
        }

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
