using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Movimiento : MonoBehaviour
{
    public GameObject Cubo;
    public GameObject PalaIz;
    public GameObject PalaDer;
    float timer = 35f;

    public TextMeshProUGUI PointsText;
    int Player1Points;
    int Player2Points;

    public GameObject ParedDer;
    public GameObject ParedIz;

    public float movSpeed;
    public float xSpeed;
    public float ySpeed;

    void Start()
    {
        movSpeed = Random.Range(5, 9);

        xSpeed = Random.Range(0, 2);

        if(xSpeed==0)
        {
            xSpeed = 1;
        }
        else
        {
           xSpeed = -1;
        }

        ySpeed = Random.Range(0, 2);

        if (ySpeed == 0)
        {
            ySpeed = 1;
        }
        else
        {
            ySpeed = -1;
        }
    }

    void Update()
    {
        transform.Translate((movSpeed * xSpeed * Time.deltaTime), (movSpeed * ySpeed * Time.deltaTime), 0);

        Debug.Log("mov " + movSpeed);
        Debug.Log("x " + xSpeed);
        Debug.Log("y " + ySpeed);
        Debug.Log("timer " + timer);

        PointsText.text = Player1Points + " - " + Player2Points;
        timer = timer + Time.deltaTime;
        if(timer < 1.5f)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ParedAbajo")
        {
            ySpeed = ySpeed * -1;
        }

        if (other.gameObject.tag == "ParedArriba")
        {
            ySpeed = ySpeed * -1;
        }

        if (other.gameObject.tag == "Pala.D")
        {
            xSpeed = xSpeed * -1;
        }

        if (other.gameObject.tag == "Pala.I")
        {
            xSpeed = xSpeed * -1;
        }

        if (other.gameObject.tag == "Player1Point")
        {
            Player1Points++;
            movSpeed = movSpeed * -1;
            timer = 0f;
        }

        if (other.gameObject.tag == "Player2Point")
        {
            Player2Points++;
            movSpeed = movSpeed * -1;
            timer = 0f;
        }
    }
}
