using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipController : MonoBehaviour
{
    public SpaceShipData[] infoNaves;

    public int Ship;
        
    float speedMov;
    float ColissionSpeed;

    public GameObject DisparoPrefab;
    Rigidbody2D rigidbody2D;
    Vector2 lookDirection = new Vector2(1, 0);
    public float speed = 3.0f;

    float cadence = 1.0f;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void VelNave()
    {
        for (int i = 0; i < infoNaves.Length; i++)
        {

            if ((i) == Ship)
            {
                speedMov = infoNaves[i].speed;
            }
            else
            {
                
            }
        }

    }

    void Update()
    {
        VelNave();

        if (Ship == 0)
        {
            speedMov = -speedMov;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localPosition.x > 9)
            {
                ColissionSpeed = 0;
            }
            else
            {
                ColissionSpeed = speedMov / 350;
            }

            transform.Translate(ColissionSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.localPosition.x < -9)
            {
                ColissionSpeed = 0;
            }
            else
            {
                ColissionSpeed = speedMov / 350;
            }

            transform.Translate(-ColissionSpeed, 0, 0);
        }
        //Debug.Log("velocidad " + ColissionSpeed);
        //Debug.Log("mov " + speedMov);
        //Debug.Log("ship " + Ship);
        //Debug.Log("cadencia " + cadence);

        cadence = cadence - Time.deltaTime;

        if(cadence <= 0)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                cadence = 1.0f;
                Launch();
            }
        }
    }

    void Launch()
    {
        GameObject RayoObject = Instantiate(DisparoPrefab, rigidbody2D.position + Vector2.up * 0.5f, Quaternion.identity);
    }
}
