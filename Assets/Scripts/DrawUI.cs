using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrawUI : MonoBehaviour
{
    public string quitScene;

    void Start()
    {
        
    }
    
    public void Quit()
    {
        SceneManager.LoadScene(quitScene);
    }
}
