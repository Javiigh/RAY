using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploArray : MonoBehaviour
{
    public int[] arrayNumeros;
    // Start is called before the first frame update
    public int GetMayor()
    {
        int mayor = arrayNumeros[0];

        for (int i = 1; i < arrayNumeros.Length; i++)
        {
            if (mayor < arrayNumeros[i])
            {
                mayor = arrayNumeros[i];
            }
        }

        return mayor;
    }

public int GetMenor()
    {
        int menor = arrayNumeros[0];

        for (int i = 1; i < arrayNumeros.Length; i++)
        {
            if (menor > arrayNumeros[i])
            {
                menor = arrayNumeros[i];
            }
        }

        return menor;
    }

public int GetRepeated(int number)
    {
        int repeatedTimes;
        for()
        {

        }

        return repeatedTimes;
    }


    void Start()
    {
        int numeroMenor = GetMEnsor();
        Debug.Log(numeroMenor);

        //Tambien se puede porner Debug:log(GetMenor());
            

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
