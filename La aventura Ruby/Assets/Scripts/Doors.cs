using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject closedoor;
    public GameObject openDoor;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        closedoor.SetActive(false);
        openDoor.SetActive(true);
        Debug.Log("Colisiona");
    }

    private void OnTriggerExit(Collider other)
    {
        closedoor.SetActive(true);
        openDoor.SetActive(false);
    }
}
