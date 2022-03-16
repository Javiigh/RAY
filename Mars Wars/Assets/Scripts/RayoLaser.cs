using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoLaser : MonoBehaviour
{
    public float speed = 0.02f;
    Rigidbody2D rigidbody2D;
    public GameObject inBunkers;

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
            //Debug.Log("ll");
        }

        else
        {
            //Debug.Log("��");
            other.gameObject.SetActive(false);
        }
        Destroy(gameObject);
    }
}
