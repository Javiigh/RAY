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

    int cuenta;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        bunker2.gameObject.SetActive(true);
        cuenta++;

        if (bunker2 == false)
        {
            bunker3.gameObject.SetActive(true);
        }

        Debug.Log("Projectile Collision with " + other.gameObject);
        //Destroy(bunker1.gameObject);
    }
}
