using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject closedoor;
    public GameObject openDoor;

    // Se le la propiedad rigid body
    Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(transform.position.magnitude > 200.0f)
        {
            Destroy(gameObject);
        }
    }

    // hacer que el proyectil sea lanzado en la misma direcci�n que Ruby y con fuerza.
    public void Launch (Vector2 direction, float force)
    {
        rigidbody2D.AddForce(direction * force);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();

        if (e != null)
        {
            e.Fix();
        }

        Destroy(gameObject);
    }
}
