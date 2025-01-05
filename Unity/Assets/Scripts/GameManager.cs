using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    string m_SceneGameName = "Game";

    public void StartGame()
    {
        StartCoroutine(LoadYourAsyncScene(m_SceneGameName));
    }

    IEnumerator LoadYourAsyncScene(string _name)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_name);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        Application.Quit();
#else
        EditorApplication.isPlaying = false;
#endif
    }
}

