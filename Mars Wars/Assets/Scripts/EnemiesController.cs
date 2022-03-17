using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemiesController : MonoBehaviour
{
    [Serializable]

    public class EnemiesList
    {
        public GameObject[] enemies;
    }

    public EnemiesList[] enemiesList;

    public GameObject LaserPrefab;
    Vector2 Aim = new Vector2(0, 0);
    Rigidbody2D rigidbody2D;

    public int points;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        PrintArray();
        //rigidbody2D = GetComponent<Rigidbody2D>();
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            
        }

        EnemigoAbajo();

        /*if (Input.GetKeyUp(KeyCode.Space))
        {
            int lastX = enemiesList.Length-1;
            int lastY = enemiesList[lastX].enemies.Length-1;
            bool FoundLastActive = false;

            //Aqui va el bucle que calcula la ultima x e y 

            for (int x = 0; x < enemiesList.Length; x++)
            {
                for (int y = 0; y < enemiesList[x].enemies.Length; y++) 
                {
                    if (enemiesList[x].enemies[y].activeSelf == false && FoundLastActive == false) //Al encontrar el desactivado paro la busqueda
                    {
                        FoundLastActive = true;
                        Debug.Log("Encontrado primero no activo x =" + lastX + "y = " + lastY);
                    }
                    else if (enemiesList[x].enemies[y].activeSelf == true && FoundLastActive == false)
                    {
                        lastX = x;
                        lastY = y;
                    }
                }
            }
            enemiesList[lastX].enemies[lastY].SetActive(false);
        }*/

    }
    // Bucle con x y otro con y, hay que ir almacenando la última x e y donde el enemigo está activo, una vez hay un enemigo dessactivado debemos dejar de contr (usar boleano).
    //desaactivar el enemigo[x].enemieList[y]

    void Shot()
    {
        //GameObject AzulObject = Instantiate(LaserPrefab, rigidbody2D.position + Vector2.up * 0.5f, Quaternion.identity);
        GameObject AzulObject = Instantiate(LaserPrefab, Aim + Vector2.up * 0.5f, Quaternion.identity);
    }

    void EnemigoAbajo()
    {
        int lastX = enemiesList.Length - 1;
        int lastY = enemiesList[lastX].enemies.Length - 1;
        bool FoundLastActive = false;

        //Aqui va el nuevo bucle que calcula la ultima x e y 

        for (int x = 0; x < enemiesList.Length; x++)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)
            {
                if (enemiesList[x].enemies[y].activeSelf == false && FoundLastActive == false) //Al encontrar el desactivado paro la busqueda
                {
                    FoundLastActive = true;
                    Debug.Log("Encontrado primero no activo x =" + lastX + "y = " + lastY);
                }
                else if (enemiesList[x].enemies[y].activeSelf == true && FoundLastActive == false)
                {
                    lastX = x;
                    lastY = y;
                }
            }
        }
        //enemiesList[lastX].enemies[lastY].SetActive(false);
    }
}
