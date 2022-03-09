using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceshipScreen : MonoBehaviour
{
    public SpaceShipData[] infoNaves;
    public GameObject[] representacionNaves;
    public GameObject[] ObjectNaves;

    string ChoosenShip;
    public int Ship = 0;
    public Image VerdeVel;
    public Image ColVida;
    public Image Potencia;


    public GameObject Pantalla;
    public GameObject Nave;
    public TextMeshProUGUI ShipName;
    public GameObject PressSpace;
    public Button ShipStarship;
    public Button ShipRazpr;
    public Button ShipShuttle;
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
            if ((i) == Ship)
            {
                ShipName.text = infoNaves[i].spaceshipName;
                ActualizarFillAmount(ColVida, infoNaves[i].shield);
                ActualizarFillAmount(Potencia, infoNaves[i].heat);
                ActualizarFillAmount(VerdeVel, infoNaves[i].speed, (0.636f / 3f));
                representacionNaves[i].SetActive(true);
                ObjectNaves[i].SetActive(true);
            }
            else
            {
                representacionNaves[i].SetActive(false);
                ObjectNaves[i].SetActive(false);
            }
        }

        GameDataPersistent.instance.selectedSpaceship = infoNaves[Ship];
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

    public void ClickShipStarship()
    {
        Ship = 0;

        GameDataPersistent.instance.selectedSpaceship = infoNaves[Ship];


        Pantalla.SetActive(false);
        PressSpace.SetActive(true);


        ButtonSound.Play(0);
    }

    public void ClickShipRazor()
    {
        Ship = 2;

        GameDataPersistent.instance.selectedSpaceship = infoNaves[Ship];


        Pantalla.SetActive(false);
        PressSpace.SetActive(true);


        ButtonSound.Play(0);
    }

    public void ClickShipShittle()
    {
        Ship = 1;

        GameDataPersistent.instance.selectedSpaceship = infoNaves[Ship];


        Pantalla.SetActive(false);
        PressSpace.SetActive(true);


        ButtonSound.Play(0);
    }
}
