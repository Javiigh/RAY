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
        Debug.Log(cuenta);

        if (bunker1 == false)
        {
            bunker2.gameObject.SetActive(true);
        }

        if (cuenta == 2)
        {
            bunker3.gameObject.SetActive(true);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hola");
        cuenta = cuenta +1;
    }
}
