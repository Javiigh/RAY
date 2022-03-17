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

    public BigMove BigMove;

    public GameObject laserAzulPrefab;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LaunchAlien();
        }
    }

    public void LaunchAlien()
    {
        //Debug.Log("Lanzando");
        GameObject LaserObject = Instantiate(laserAzulPrefab, rigidbody2D.position + Vector2.up * 0.5f, Quaternion.identity);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("col");
        if (other.gameObject.tag == "LateralD")
        {
            BigMove.ColisionD();
        }

        else
        {
          if (other.gameObject.tag == "LateralI")
            {
                BigMove.ColisionI();
            }
        }
    }
}
