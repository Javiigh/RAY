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
    public GameObject Rayo2Prefab;
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

        cadence = cadence - Time.deltaTime;

        if(cadence <= 0)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                cadence = 1.0f;
                Launch();
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                cadence = 1.0f;
                Launch2();
            }
        }
    }

    void Launch()
    {
        GameObject RayoObject = Instantiate(DisparoPrefab, rigidbody2D.position + Vector2.up * 0.5f, Quaternion.identity);
    }

    void Launch2()
    {
        GameObject Rayo2Object = Instantiate(Rayo2Prefab, rigidbody2D.position + Vector2.up * 0.5f, Quaternion.identity);
    }

    public void dead()
    {
      GameObject Screen = Instantiate(FinalScreenPrefab, new Vector2(0, 0), Quaternion.identity);
    }

    public void Heat()
    {
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

        if (other.gameObject.tag == "Alien1" && other.gameObject.tag == "Alien2" && other.gameObject.tag == "Alien3") 
        {
            life = 0;
        }
    }
}
