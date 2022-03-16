using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SecondLevelLoader : MonoBehaviour
{
    public Animator transition;
    public float Timer = 0f;
    bool touchEnded = false;

    public Button MainScreen;

    void Update()
    {

    }

    public void ClickMainScreen()
    {
        LoadMainScreen();
    }

    public void LoadMainScreen()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }

    IEnumerator LoadLevel(int LevelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(LevelIndex);
    }
}
