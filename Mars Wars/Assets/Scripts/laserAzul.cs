using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserAzul : MonoBehaviour
{
    public float speed = 0.02f;
    Rigidbody2D rigidbody2D;

    public ShipController ShipController;
    public float ShipLife;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.magnitude > 20.0f)
        {
            Destroy(gameObject);
        }
        else
        {
            Launch();
        }
    }

    public void Launch()
    {
        transform.Translate(0, -speed, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "InBunkers")
        {
            
        }

        else if (other.gameObject.tag == "Nave")
        {
            //ShipController.Heat(-1);
            ShipLife = -1;
        }
        Destroy(gameObject);
    }
}
