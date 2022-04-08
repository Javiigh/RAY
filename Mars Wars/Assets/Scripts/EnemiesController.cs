using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class EnemiesController : MonoBehaviour
{
    [Serializable]
    public class EnemiesList
    {
        public GameObject[] enemies;
    }

    public EnemiesList[] enemiesList;

    public GameObject LaserPrefab;
    Vector2 Aim;
    Rigidbody2D rigidbody2D;
    public AlienMove alienMove;

    public int Shoter;
    float timer;

    public int Fila = 1;
    public static EnemiesController instance;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        if (EnemiesController.instance == null)
        {
            EnemiesController.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        PrintArray();
    }

    void PrintArray()
    {
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemielist
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++) 
            {
                if (enemiesList[x].enemies[y].activeSelf == true)
                {
                    Debug.Log(enemiesList[x].enemies[y].name);
                }
            }
        }
    }

    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer > 1.5)
        {
            ChooseShoter();
            timer = 0;
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            Shot();
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            EnemigoAbajo();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            alienMove.LaunchAlien();
        }
    }

    void Shot()
    {
        EnemigoAbajo();
        GameObject AzulObject = Instantiate(LaserPrefab, Aim + Vector2.up * 0.2f, Quaternion.identity);
    }

    void EnemigoAbajo()
    {
        int lastX = enemiesList.Length - 1;
        int lastY = enemiesList[lastX].enemies.Length - 1;
        bool FoundLastActive = false;

        for (int x = 0; x < enemiesList.Length; x++)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)
            {
                if (enemiesList[x].enemies[y].activeSelf == false && FoundLastActive == false) //Al encontrar el desactivado paro la busqueda
                {
                    FoundLastActive = true;
                    //Debug.Log("Encontrado primero no activo x =" + lastX + "y = " + lastY);
                }
                else if (enemiesList[x].enemies[y].activeSelf == true && FoundLastActive == false)
                {
                    lastX = x;
                    lastY = y;
                }
            }
        }
        Aim = enemiesList[lastX].enemies[Shoter].transform.localPosition;
        Aim = Aim - new Vector2(0, -2);
    }

    void ChooseShoter()
    {
        Shoter = Random.Range(0, 6);
        Shot();
    }

    public void Ultimafila()
    {
        int columna = enemiesList.Length - 1;
        int lastFila = enemiesList[columna].enemies.Length - 1;
        bool LastRow = false;

        for (int x = 0; x < enemiesList.Length; x++)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)
            {
                if (enemiesList[x].enemies[y].activeSelf == false && LastRow == false)
                {
                    LastRow = true;
                    Fila = x;
                }
                else if (enemiesList[x].enemies[y].activeSelf == true && LastRow == false)
                {
                    columna = x;
                    lastFila = y;
                    Debug.Log("no ");
                }

                if ((enemiesList[0].enemies[y].activeSelf == false) == enemiesList[columna].enemies[lastFila])
                {
                    Rayo3.instance.Damage();
                    Debug.Log("fila " + Fila);
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
            other.gameObject.SetActive(false);
    }
}
