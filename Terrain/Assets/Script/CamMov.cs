using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMov : MonoBehaviour
{
    public float speed = 20f;
    private Vector3 motion;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        /*motion = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rb.velocity = motion * speed;*/
        //this.gameObject.transform.Translate(0, 0, Time.deltaTime);
        transform.Translate(0, 0, Time.deltaTime* 60);
    }
}
