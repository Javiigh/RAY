using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBunker : MonoBehaviour
{
    public GameObject bunker1;
    public GameObject bunker2;
    public GameObject bunker3;
    Rigidbody2D rigidbody2D;

    int cuenta;

    void Start()
    {
        
    }

    void Update()
    {
        //Debug.Log(cuenta);

        if(cuenta == 2)
        {
            bunker1.gameObject.SetActive(false);
            bunker2.gameObject.SetActive(true);
        }
        else
        {
            if (cuenta == 4)
            {
                bunker2.gameObject.SetActive(false);
                bunker3.gameObject.SetActive(true);
            }
            else
            {
                if (cuenta ==6)
                {
                    bunker3.gameObject.SetActive(false);
                    Destroy(gameObject);
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        cuenta++;
        //bunker1.gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}
