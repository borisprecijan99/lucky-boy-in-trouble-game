using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    
    public void Resume()
    {
        /*gameObject.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;*/
    }

    public void MainMenu()
    {
        StartCoroutine(LoadScene("MainMenu"));
    }

    public bool IsPaused()
    {
        return isPaused;
    }

    public void Pause()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    private IEnumerator LoadScene(string name)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(name);
    }
}
