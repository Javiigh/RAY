using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Proyecto : MonoBehaviour
{
    public GameObject Inicial;
    public GameObject Juego;
    public GameObject Jb;
    public GameObject SB;
    public float Tiempo = 0.0f;
    public TextMeshProUGUI Crono;
    public TextMeshProUGUI resultado;
    public TextMeshProUGUI info;
    public TextMeshProUGUI ScoreBoard;
    public bool Boton = false;
    private int goalsPlayer1 = 0;
    private int goalsPlayer2 = 0;
    private int playerTurn = 1;


    void Start()
    {

    }

    void Update()
    {
        // cronometro += Time.deltaTime;
        Crono.text = Tiempo.ToString("0.00");

        Debug.Log(Tiempo);

        if (Boton == true)
        {
            Tiempo = Tiempo + Time.deltaTime;
            Jb.SetActive(false);
            SB.SetActive(true);
        }
        else
        {
            Jb.SetActive(true);
            SB.SetActive(false);
        }
              
    }

    public void ClickJugarButton()
    {
        Inicial.SetActive(false);
        Juego.SetActive(true);
        resultado.text = "";
    }

    public void ClickJbButton()
    {
        Boton = !Boton;
        GetResult(Tiempo);
    }

    public void ClickSbButton()
    {
        Boton = !Boton;
        ScoreBoard.text = goalsPlayer1 + " - " + goalsPlayer2;
    }

    public float GetDecimals(float number)
    {
        return number % 1;
    }
    
    public string GetResult(float Tiempo)
    {
        float decimals = GetDecimals(Tiempo);

        if (decimals >= 0.0f & decimals < 0.25f)
        {
            resultado.text = "GOL";
            //      AUMENTAR GOLES

            //      ACTUALIZA MARCADOR  
            UpdateScoreBoard();
            //       CAMBIA DE JUGADOR
            UpdatePlayerTurn();
            // ACTUALIZA INFOGAME
            info.text = "Le toca al jugador " + playerTurn;
        }

        else if (decimals > 0.25f & decimals <= 0.75f)
        {
            resultado.text = "Fuera";
            //       CAMBIA DE JUGADOR
        }

        else
        {
            resultado.text = "Falta";
            //       CAMBIA DE JUGADOR
        }

        return Tiempo.ToString("0.00");
    }

    public void UpdatePlayerTurn()
    {
        if (playerTurn == 1)
        {
            playerTurn = 2;
        }
        else
        {
            playerTurn = 1;
        }
    }

    private void UpdateScoreBoard()
    {
        if (playerTurn == 1)
        {
            goalsPlayer1 = goalsPlayer1 + 1;
        }
        else if (playerTurn == 2)
        {
            goalsPlayer2 = goalsPlayer2 + 1;
        }
    }

}
