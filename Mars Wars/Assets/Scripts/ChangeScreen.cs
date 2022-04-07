using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScreen : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject nextScreen;
    public AudioSource efectsSource;

    public void NextScreen()
    {
        currentScreen.SetActive(false);
        nextScreen.SetActive(true);
        efectsSource.Play(0);
    }
}
