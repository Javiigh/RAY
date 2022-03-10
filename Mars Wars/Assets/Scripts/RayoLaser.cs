using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoLaser : MonoBehaviour
{
    public GameObject Laser;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
           Laser.SetActive(true);
        }
    }
}
