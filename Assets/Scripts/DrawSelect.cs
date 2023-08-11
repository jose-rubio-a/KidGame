using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrawSelect : MonoBehaviour
{
    public string quitScene, level1, level2;

    void Start()
    {
        
    }

    public void Draw1()
    {
        SceneManager.LoadScene(level1);
    }

    public void Draw2()
    {
        SceneManager.LoadScene(level2);
    }

    public void Quit()
    {
        SceneManager.LoadScene(quitScene);
    }
}
