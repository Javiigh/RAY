using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bunkers : MonoBehaviour
{
    public GameObject bunker1;
    public GameObject bunker2;
    public GameObject bunker3;
    Rigidbody2D rigidbody2D;

    public int cuenta = 0;

    void Start()
    {
        //bunker2.gameObject.SetActive(true);
    }

    void Update()
    {
        Debug.Log("está ");
        Debug.Log("cuenta " + cuenta);

        if (cuenta >=1)
        {
            bunker1.gameObject.SetActive(false);
            bunker2.gameObject.SetActive(true);
            Debug.Log("no está ");

            if (bunker2 == false)
            {
                bunker3.gameObject.SetActive(true);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        cuenta = cuenta + 1;
        Debug.Log("Projectile Collision with " + other.gameObject);
        //Destroy(bunker1.gameObject);
    }
}
