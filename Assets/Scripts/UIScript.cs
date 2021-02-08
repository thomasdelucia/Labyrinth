using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");

    }

    public void Continue()
    {

        int LevelToLoad = PlayerPrefs.GetInt("DernierNiveau");
        if(LevelToLoad>1)
        {
            SceneManager.LoadScene(LevelToLoad);
        }

        else
        {
            SceneManager.LoadScene("Level1");
        }

    }


}

