using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    void Awake()
    {
        //GameObject nave = Instantiate(GameDataPersistent.instance.selectedSpaceship.prefab);
        GameObject nave = Instantiate(GameDataPersistent.instance.selectedSpaceship.prefab);
        //nave.transform.localScale *= 10f;
    }
}
