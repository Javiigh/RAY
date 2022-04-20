using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMov : MonoBehaviour
{
    public float speed = 2f;
    public float timer;
    public float timer2;
    private Vector3 motion;
    private Rigidbody rb;

    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject Cam3;
    public GameObject EmptyCM1;

    public GameObject Water;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cam2.SetActive(true);
        Cam1.SetActive(false);
    }

    void Update()
    {
        EmptyCM1.transform.Translate(0, Time.deltaTime * 60, 0);

        timer = timer + Time.deltaTime;
        if (timer > 10)
        {
            Cam2.SetActive(false);
            Cam1.SetActive(true);
        }

        if (timer > 15 && timer < 28.5)
        {
            Cam1HM();
        }

        if (timer > 18)
        {
            timer2 = timer2 + Time.deltaTime;
            transform.Translate(0, Time.deltaTime * 45, 0);
        }

        if (timer2 > 0 && timer2 < 9)
        {
            Cam1.transform.Rotate(Time.deltaTime * 9, 0, 0);
        }

        if (timer > 30 && timer <= 36.82204)
        {
            Cam3.transform.Translate(0, -(Time.deltaTime * 25), 0);
        }

        if (timer > 30)
        {
            Cam1.SetActive(false);
            Cam3.SetActive(true);
        }

        if (timer > 36)
        {
            Cam3.transform.Rotate(0, Time.deltaTime * 12, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Water.SetActive(false);
        }
    }

    void Cam1HM()
    {
        transform.Translate(0, 0, Time.deltaTime * 40);
    }
}
