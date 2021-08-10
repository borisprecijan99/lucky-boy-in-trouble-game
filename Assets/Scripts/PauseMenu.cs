using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused;
    
    public void Resume()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
