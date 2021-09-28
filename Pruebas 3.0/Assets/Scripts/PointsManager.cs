using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    //Miembro estático que nadie podrá acceder, sirve como seguridad.
    //Es del mismo tipo de dato que la clase

    private static PointsManager _instance;

    //Para dar acceso a cualquier script
    public static PointsManager Instance { get { return _instance; } }

    //Hacer privados los puntos para que no puedan acceder
    private int _points;
    //A través de esta referencia pueden ser accedidos
    public int Points { get { return _points; } }

    int points = 0;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void AddPoints(int amount)
    {
        _points += amount;
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
