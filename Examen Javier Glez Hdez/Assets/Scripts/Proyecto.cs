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
    public TextMeshProUGUI Resultado;
    public TextMeshProUGUI infoGame;
    public bool Boton = false;
    public float Score = 0.0f;
    private int goalsPlayer1 = 0;
    private int goalsPlayer2 = 0;
    private int playerTurn = 1;


    void Start()
    {

    }

    void Update()
    {

        // cronometro += Time.deltaTime;
        // labelCrono.text = cronometro.ToString("0.00");

        Debug.Log(Tiempo);
        Debug.Log(Score + " Puntos");

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

        Crono.text = Tiempo + " Segundos";

        Score = Tiempo;

        if (Score >= 1)
        {
            Score = 0 + Time.deltaTime;
        }

        if (Score >= 0 && Score < 0.25)
        {
            Resultado.text = "Gol";
        }

        else
        {
            if (Score >= 0.26 && Score < 0.80)
            {
                Resultado.text = "Pierde la pelota";
            }

            else
            {
                Resultado.text = "Falta";
            }
        }

    }

    public void ClickJugarButton()
    {
        Inicial.SetActive(false);
        Juego.SetActive(true);
    }

    public void ClickJbButton()
    {
        Boton = !Boton;
        Tiempo = 0.0f;
    }

    public void ClickSbButton()
    {
        Boton = !Boton;

    }

    public float GetDecimals(float Tiempo)
    {
        return Tiempo % 1;
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

    private void ScoreGoal()
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

    //  public float GetDecimals (float number)
    //  {
    //    return number % 1;
    //  }

    // public string GetResult(float time)
    // {
    //   string resultado = "Mostrar resultado jugada";
    //   float decimals = GetDecimals(time);

    // if (decimals >= 0.0f & decimals <0.25f)
    // {
    //   resultado = "GOL";
    //       MARCA GOL Y
    //
    //       CAMBIA DE JUGADOR
    // UpdatePlayerTurn();
    // ACTUALIZA INFOGAME
    // info.game.text = "Le toca al jugador" + playerTurn;
    // }

    // else if (decimals > 0.25f & decimals <=0.75f)
    // {
    //  resultado = fuera;
    //       CAMBIA DE JUGADOR
    // }

    // else
    // {
    //  resultado = "Falta";
    //       CAMBIA DE JUGADOR
    // }
    //   return resultado;
    // }
}
