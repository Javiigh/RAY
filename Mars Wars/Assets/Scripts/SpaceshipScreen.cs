using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceshipScreen : MonoBehaviour
{
    public SpaceShipData[] infoNaves;
    public GameObject[] representacionNaves;

    string ChoosenShip;
    int Ship = 0;
    public Image VerdeVel;
    public Image ColVida;
    public Image Potencia;


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

    public void ActualizarUINave()
    {
        for (int i = 0; i < infoNaves.Length; i++)
        {
            if ((i + 1) == Ship)
            {
                ShipName.text = infoNaves[i].spaceshipName;
                ActualizarFillAmount(ColVida, infoNaves[i].shield);
                ActualizarFillAmount(Potencia, infoNaves[i].heat);
                ActualizarFillAmount(VerdeVel, infoNaves[i].speed, (0.636f / 3f));
                representacionNaves[i].SetActive(true);

            }
            else
            {
                representacionNaves[i].SetActive(false);
            }
        }

        GameDataPersistent.instance.selectedSpaceship = infoNaves[i];
    }


    void ActualizarFillAmount(Image imageGeneric, float valor, float reglaTres = 1.0f/3.0f)
    {
        if (imageGeneric.fillAmount < (valor * reglaTres))
        {
            imageGeneric.fillAmount += Time.deltaTime * speed;
        }
        else if (imageGeneric.fillAmount > (valor * reglaTres))
        {
            imageGeneric.fillAmount -= Time.deltaTime * speed;
        }

    }

    void Update()
    {
        ActualizarUINave();
    }

    public void ClickShip1()
    {
        Ship = 1;


        Pantalla.SetActive(false);


        ButtonSound.Play(0);
    }

    public void ClickShip2()
    {
        Ship = 2;


        Pantalla.SetActive(false);


        ButtonSound.Play(0);
    }

    public void ClickShip3()
    {
        Ship = 3;


        Pantalla.SetActive(false);


        ButtonSound.Play(0);
    }
}
