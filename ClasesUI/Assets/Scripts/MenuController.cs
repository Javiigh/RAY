using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;

    public GameObject MenuPausa;

    void Awake()
    {
        if (instance != null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void EnableMenuPausa()
    {
        MenuPausa.SetActive(true);
    }

    public void DisableMenuPausa()
    {
        MenuPausa.SetActive(false);
    }

}
