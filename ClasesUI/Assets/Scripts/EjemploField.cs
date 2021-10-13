using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EjemploField : MonoBehaviour
{
    public TMP_InputField fieldName;
    public GameObject WelcomeScreen;
    public GameObject loginScreen;
    public TextMeshProUGUI nameTextLabel;
   
    void Start()
    {
        
    }

  
    void Update()
    {
        Debug.Log(fieldName.text);
    }

    public void ClickLoginButton()
    {
        loginScreen.SetActive(false);
        WelcomeScreen.SetActive(true);
        nameTextLabel.text = "Hola" + fieldName.text;
    }

   


}
