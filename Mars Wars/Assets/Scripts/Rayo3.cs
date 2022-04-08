using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayo3 : MonoBehaviour
{
    public float speed = 0.03f;
    public static Rayo3 instance;


    void Awake()
    {
        if (Rayo3.instance == null)
        {
            Rayo3.instance = this;
        }
        else
        {
            Destroy(this);
        }
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
                CounterPoints.instance.SumaPuntos(10);
            }
            if (other.gameObject.tag == "Alien2")
            {
                CounterPoints.instance.SumaPuntos(20);
            }
            if (other.gameObject.tag == "Alien3")
            {
                CounterPoints.instance.SumaPuntos(30);
            }
            if (other.gameObject.tag == "Nodrizass")
            {
                CounterPoints.instance.SumaPuntos(50);
            }
            other.gameObject.SetActive(false);
        }
    }
}
