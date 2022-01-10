using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float Tiempo = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Tiempo > 0.0f)
        {
            Tiempo = Tiempo - Time.deltaTime;
            Debug.Log(Tiempo + "s");
        }

        else
        {
            Debug.Log("El tiempo se ha acabado");
            Destroy(gameObject);
        }
    }
}
