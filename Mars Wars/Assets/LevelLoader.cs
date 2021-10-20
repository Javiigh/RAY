using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float Timer = 0f;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
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
