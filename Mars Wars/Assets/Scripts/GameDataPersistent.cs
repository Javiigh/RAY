using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataPersistent : MonoBehaviour
{
    public SpaceShipData selectedSpaceship;
    public static GameDataPersistent instance;
    public GameObject Nave;

    public ShipController ship;

    void Awake()
    {
        if (GameDataPersistent.instance == null)
        {
            GameDataPersistent.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
