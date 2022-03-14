using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoLaser : MonoBehaviour
{
    public float speed = 0.02f;
    Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.magnitude > 200.0f)
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

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Projectile Collision with " + other.gameObject);
        Destroy(gameObject);
    }
}
