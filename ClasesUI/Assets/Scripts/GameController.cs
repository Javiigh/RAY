using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Si presiono Escape

        if(Input.GetKeyUp(KeyCode.Escape) == true)
        {
            MenuController.instance.EnableMenuPausa();
        }

       
    }
}
