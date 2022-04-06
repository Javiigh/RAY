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
    public laserAzul laserAzul;
    public GameObject FinalScreenPrefab;
    public static ShipController instance;
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
        for (int i = 0; i < infoNaves.Length; i++)
        {
            if ((i) == Ship)
            {
               life = infoNaves[i].shield;

            }
            else
            {

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
        Heat();

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
        //Debug.Log("vidass" + life);

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

    public void dead()
    {
      GameObject Screen = Instantiate(FinalScreenPrefab, new Vector2(0, 0), Quaternion.identity);
    }

    public void Heat()
    {
        //Debug.Log("Lifell" + life);
        if (life == 0)
        {
            dead();
        }
            
        for (int i = 0; i < infoNaves.Length; i++)
        {
            if ((i) == Ship)
            {
                life = infoNaves[i].shield;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "LaserAzul")
        {
            life = life -1;
        }
    }
}
