using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "SpaceShip", order = 1)]

public class SpaceShipData : ScriptableObject
    //Importante cambiar de Monobehaviur a ScriptableObject
{
    public string spaceshipName;
    [Range (0, 3.0f)]
    public float shield;
    [Range(0, 3.0f)]
    public float speed;
    [Range(0, 3.0f)]
    public float heat;
}
