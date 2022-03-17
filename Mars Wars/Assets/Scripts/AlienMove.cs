using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMove : MonoBehaviour
{
    float speedMov = 2 ;
    float EjeXSpeed;
    float timeX;
    float timeY;

    Rigidbody2D rigidbody2D;
    Vector2 lookDirection = new Vector2(1, 0);
    public float speed = 3.0f;

    public int choque;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        timeX = timeX + Time.deltaTime;
        timeY = timeY + Time.deltaTime;

        //Debug.Log(timeX);
        Debug.Log(choque);
        Debug.Log(EjeXSpeed);

        if (Input.GetKey(KeyCode.L))
        {
            movXD();
        }
    }

    void Launch()
    {
        //GameObject RayoObject = Instantiate(DisparoPrefab, rigidbody2D.position + Vector2.up * 0.5f, Quaternion.identity);
    }

    void movXD()
    {
        EjeXSpeed = speedMov / 10;

        if (choque == 1)
        {
            transform.Translate(-EjeXSpeed, 0, 0);
        }
        else
        {
            transform.Translate(EjeXSpeed, 0, 0);
        }

    }

    void movY()
    {
        if (transform.localPosition.x > 9)
        {
            //ColissionSpeed = 0;
        }
        else
        {
            //ColissionSpeed = speedMov / 10;
        }

        //transform.Translate(ColissionSpeed, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("col");
        choque++;

        if (other.gameObject.tag == "Laterales")
        {
            EjeXSpeed = -EjeXSpeed;
        }

        else
        {
            
        }
        
    }
}
