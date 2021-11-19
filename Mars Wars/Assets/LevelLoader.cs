using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float Timer = 0f;
    bool touchEnded = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Ended)
            {
                
                touchEnded = true;
            }
        }

        else
        {
            touchEnded = false;
        }

        if(Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0)
        {
            LoadNextLevel();
        }

        Timer = Timer + Time.deltaTime;
        Debug.Log(Timer);

        if(Timer >= 90f)
        {
            LoadNextLevel();
        }

    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int LevelIndex)
    {
        //Play animation
        transition.SetTrigger("Start");

        //Wait
        yield return new WaitForSeconds(1);

        //Load scene
        SceneManager.LoadScene(LevelIndex);
    }
}
