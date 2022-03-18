using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipController : MonoBehaviour
{
    public SpaceShipData[] infoNaves;

    public int Ship;

    public float life;
    public static ShipController instance;
    float speedMov;
    float ColissionSpeed;

    public GameObject DisparoPrefab;
    Rigidbody2D rigidbody2D;
    Vector2 lookDirection = new Vector2(1, 0);
    public float speed = 3.0f;

    float cadence = 1.0f;
    public GameObject FinalScreen;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        for (int i = 0; i < infoNaves.Length; i++)
        {
            if ((i) == Ship)
            {
                life = infoNaves[i].shield;
            }
        }
    }

    void Awake()
    {
        if (ShipController.instance == null)
        {
            ShipController.instance = this;
        }
        else
        {
            Destroy(this);
        }

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

        if(Ship == 1)
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
        Debug.Log("Vida " + life);

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

    public void Heat(int amount)
    {
        life += amount;
    }

    void dead()
    {
        if (life <= 0)
        {
            FinalScreen.SetActive(true);
        }
    }
}
