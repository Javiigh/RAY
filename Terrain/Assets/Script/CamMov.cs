using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMov : MonoBehaviour
{
    public float speed = 20f;
    public float timer;
    private Vector3 motion;
    private Rigidbody rb;

    public GameObject Cam1;
    public GameObject Cam2;
    public GameObject EmptyCM1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cam2.SetActive(true);
        Cam1.SetActive(false);
    }

    void Update()
    {
        /*motion = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rb.velocity = motion * speed;*/
        //this.gameObject.transform.Translate(0, 0, Time.deltaTime);
        EmptyCM1.transform.Translate(0, Time.deltaTime * 60, 0);

        timer = timer + Time.deltaTime;
        if (timer > 8)
        {
            Cam2.SetActive(false);
            Cam1.SetActive(true);
            transform.Translate(0, 0, Time.deltaTime * 60);
        }
    }
}
