using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceshipScreen : MonoBehaviour
{
    public int[] ArrayShips;
    public SpaceShipData infoSpaceShip;
    public SpaceShipData infoSpaceShip2;
    public SpaceShipData infoSpaceShip3;
    string ChoosenShip;
    int Ship = 0;
    public Image VerdeVel;
    public Image ColVida;
    public Image Potencia;
    public GameObject Video;
    public GameObject Nave2;
    public GameObject Nave3;
    public GameObject Pantalla;
    public TextMeshProUGUI ShipName;
    public Button Ship1;
    public Button Ship2;
    public Button Ship3;
    private float speed = 0.3f;
    public AudioSource ButtonSound;

    void Start()
    {
        VerdeVel.fillAmount = 0;
        ColVida.fillAmount = 0;
        Potencia.fillAmount = 0;
    }

    void Update()
    {
        if(Ship == 1)
    {
            if (VerdeVel.fillAmount < (infoSpaceShip.speed * 0.636 / 3))
            {
                Debug.Log("Speed" + VerdeVel.fillAmount);
                VerdeVel.fillAmount += Time.deltaTime * speed;
            }

            if (ColVida.fillAmount < (infoSpaceShip.shield * 1 / 3))
            {
                Debug.Log("Speed" + ColVida.fillAmount);
                ColVida.fillAmount += Time.deltaTime * speed;
            }

            if (Potencia.fillAmount < (infoSpaceShip.heat * 1 / 3))
            {
                Debug.Log("Speed" + Potencia.fillAmount);
                Potencia.fillAmount += Time.deltaTime * speed;
            }
            ShipName.text = infoSpaceShip.spaceshipName;
        }

        else
            if (Ship == 2)
        {
            if (VerdeVel.fillAmount < (infoSpaceShip2.speed * 0.636 / 3))
            {
                Debug.Log("Speed" + VerdeVel.fillAmount);
                VerdeVel.fillAmount += Time.deltaTime * speed;
            }

            if (ColVida.fillAmount < (infoSpaceShip2.shield * 1 / 3))
            {
                Debug.Log("Speed" + ColVida.fillAmount);
                ColVida.fillAmount += Time.deltaTime * speed;
            }

            if (Potencia.fillAmount < (infoSpaceShip2.heat * 1 / 3))
            {
                Debug.Log("Speed" + Potencia.fillAmount);
                Potencia.fillAmount += Time.deltaTime * speed;
            }
            ShipName.text = infoSpaceShip2.spaceshipName;
        }

        else
            if (Ship == 3)
        {
            if (VerdeVel.fillAmount < (infoSpaceShip3.speed * 0.636 / 3))
            {
                Debug.Log("Speed" + VerdeVel.fillAmount);
                VerdeVel.fillAmount += Time.deltaTime * speed;
            }

            if (ColVida.fillAmount < (infoSpaceShip3.shield * 1 / 3))
            {
                Debug.Log("Speed" + ColVida.fillAmount);
                ColVida.fillAmount += Time.deltaTime * speed;
            }

            if (Potencia.fillAmount < (infoSpaceShip3.heat * 1 / 3))
            {
                Debug.Log("Speed" + Potencia.fillAmount);
                Potencia.fillAmount += Time.deltaTime * speed;
            }
            ShipName.text = infoSpaceShip3.spaceshipName;
        }
    }

    public void ClickShip1()
    {
        Ship = 1;
        Video.SetActive(true);
        Nave2.SetActive(false);
        Nave3.SetActive(false);
        Pantalla.SetActive(false);
        VerdeVel.fillAmount = 0;
        ColVida.fillAmount = 0;
        Potencia.fillAmount = 0;
        ButtonSound.Play(0);
    }

    public void ClickShip2()
    {
        Ship = 2;
        Video.SetActive(false);
        Nave2.SetActive(true);
        Nave3.SetActive(false);
        Pantalla.SetActive(false);
        VerdeVel.fillAmount = 0;
        ColVida.fillAmount = 0;
        Potencia.fillAmount = 0;
        ButtonSound.Play(0);
    }

    public void ClickShip3()
    {
        Ship = 3;
        Video.SetActive(false);
        Nave2.SetActive(false);
        Nave3.SetActive(true);
        Pantalla.SetActive(false);
        VerdeVel.fillAmount = 0;
        ColVida.fillAmount = 0;
        Potencia.fillAmount = 0;
        ButtonSound.Play(0);
    }
}
