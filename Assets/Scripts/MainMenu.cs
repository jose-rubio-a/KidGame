using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string StarScene;
    void Start()
    {
        
    }

    public void StarGame()
    {
        SceneManager.LoadScene(StarScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
