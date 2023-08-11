using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelect : MonoBehaviour
{

    public string drawSelect, quitScene;

    public void DrawGame()
    {
        SceneManager.LoadScene(drawSelect);
    }

    public void QuitSelect()
    {
        SceneManager.LoadScene(quitScene);
    }
}
