using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;

    public GameObject PantallaEspera;
    public GameObject MenuSettings;

    void Awake()
    {
        if (instance == null)
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
        PantallaEspera.SetActive(true);
    }

    public void DisableMenuPausa()
    {
        PantallaEspera.SetActive(false);
    }

    public void EnableMenuSettings()
    {
        MenuSettings.SetActive(true);
    }

    public void DisableMenuSettings()
    {
        MenuSettings.SetActive(false);
    }
}
