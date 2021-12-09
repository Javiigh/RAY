using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceshipScreen : MonoBehaviour
{

    public SpaceShipData infoSpaceShip;
    public Slider speedSlider;
    public Slider shieldSlider;
    public Slider heatSlider;
    public TextMeshProUGUI ShipName;
    private float speed = 1f;
    public Transform iconShield;

    void Start()
    {
        speedSlider.value = 0;
        shieldSlider.value = 0;
        heatSlider.value = 0;
    }

    void Update()
    {
        /*Debug.Log(infoSpaceShip.speed);
        Debug.Log(infoSpaceShip.shield);
        Debug.Log(infoSpaceShip.heat);
        Debug.Log(infoSpaceShip.spaceshipName);

        speedSlider.value = infoSpaceShip.speed;
        shieldSlider.value = infoSpaceShip.shield;
        heatSlider.value = infoSpaceShip.heat;
        Nombre = spaceshipName;
        */

        //ShipName = infoSpaceShip.spaceshipName;

        if (shieldSlider.value < infoSpaceShip.shield)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

        if (speedSlider.value < infoSpaceShip.speed)
        {
            speedSlider.value += Time.deltaTime * speed;
        }

        if (heatSlider.value < infoSpaceShip.heat)
        {
            heatSlider.value += Time.deltaTime * speed;
        }
    }


    /*Ejemplo con imagen:
     * 
     * public SpaceshipData myShip;
    public GameObjct iconParents;

    en update

    for(int iconoModificado =0 < iconParents.childCount; iconoModificado++)
    {

        if (myShip.speed > iconoModificado).gameObject.SetActive(true);
        {
            iconParents.GetChild(iconoModificado).gameObject.SetActive(true);
        }
        else
        {
            inconParents.GetChild(iconoModificado).gameObject.SetActive(false);
        }


    }

     ****Una para Shiel, heat y speed.
   */
}
