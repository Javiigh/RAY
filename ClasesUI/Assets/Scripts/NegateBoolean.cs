using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegateBoolean : MonoBehaviour
{
    public bool isAlive = true;
    public TextMeshProUGUI label;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        label.text = isAlive.ToString();

        if (Input.GetKeyUp(KeyCode.Space))
        {
            //También se puede usar isAlive = !isAlive;

           if (isAlive == true)
            {
                isAlive = false;
            }  

           else
            {
                isAlive = true;
            }
        }
    }
}
