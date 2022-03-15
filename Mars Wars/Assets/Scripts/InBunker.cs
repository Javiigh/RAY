using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBunker : MonoBehaviour
{
    int count;
    GameObject lla;

    Rigidbody2D rigidbody2D;
    public Bunkers bunkers;

    void Start()
    {
        bunkers = GameObject.Find("Cuenta").GetComponent<Bunkers>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //bunkers.cuenta++;
        //gameObject.setActive(false);
        //Destroy(lla);
    }
}
