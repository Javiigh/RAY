using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoLaser : MonoBehaviour
{
    public float speed = 0.02f;
    Rigidbody2D rigidbody2D;

    public CounterPoints CounterPoints;
    

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

        //inBunkers.SetActive(true);
    }

    public void Launch()
    {
        transform.Translate(0, speed, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "InBunkers")
        {
            
        }

        else
        {
            if (other.gameObject.tag == "Alien1")
            {
                CounterPoints.PuntoVerde();
                Debug.Log("Si");
            }
            if (other.gameObject.tag == "Alien2")
            {
                CounterPoints.PuntoRojo();
            }
            if (other.gameObject.tag == "Alien3")
            {
                CounterPoints.PuntoAzul();
            }
            other.gameObject.SetActive(false);
        }
        Destroy(gameObject);
    }

    
}
