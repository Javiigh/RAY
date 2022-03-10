using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    float speed;
    float ColissionSpeed;

    //public GameObject Nave;
    void Start()
    {
        
    }

    void Update()
    {
        //SpaceShipData speed = GetComponent<SpaceShipData>();

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localPosition.x > 5)
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
            if (transform.localPosition.x > 5)
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
