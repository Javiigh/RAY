using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FinalScreen : MonoBehaviour
{
    public Button Replay;
    public Button MainScreen;
    public TextMeshProUGUI Score;

    void Awake()
    {
        Score.text = "" + CounterPoints.instance.Points.ToString();
    }

    void Update()
    {
        Score.text = CounterPoints.instance.Points.ToString();
        Debug.Log(CounterPoints.instance.Points);
    }

    public void ClickReplay()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void ClickMainScreen()
    {
        LoadPrevLevel();
    }

    public void LoadPrevLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }

    IEnumerator LoadLevel(int LevelIndex)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(LevelIndex);
    }
}
