using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Movimiento : MonoBehaviour
{
    public GameObject PantallaIn;
    public Button Comenzar;
    public GameObject Cubo;
    public GameObject ParedIz;
    public GameObject ParedDer;
    public float movSpeed = 2f;
    public float xrange = 10;
    public float yrange = 10;
    public float zrange = 0;


    void Start()
    {
        
    }

    public void ClickComenzar()
    {
        PantallaIn.SetActive(false);
        Cubo.SetActive(true);
    }

    void Update()
    {
        //transform.Translate(Vector3.right * Time.deltaTime * movSpeed);
        //transform.Translate(xrange * Time.deltaTime * movSpeed, yrange * Time.deltaTime * movSpeed, 0) ;

        transform.Translate(1 * Time.deltaTime * movSpeed, 0, zrange*0);

        Debug.Log(xrange);
        Debug.Log(yrange);
        Debug.Log(zrange);

        
    }

    void RamdonPosition()
    {
        xrange = Random.Range(-1f, 1f);
        yrange = Random.Range(-1f, 1f);
       
    }

    public void OnTriggerEnter(Collider other)
    {
        movSpeed = movSpeed * -1;
    }
}
