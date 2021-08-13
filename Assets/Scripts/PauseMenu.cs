using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    private GameObject pauseMenuPanel;

    void Start()
    {
        Canvas canvas = FindObjectOfType<Canvas>();
        pauseMenuPanel = canvas.transform.Find("PauseMenu").gameObject;
    }
    
    public void Resume()
    {
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        HidePauseMenu();
    }

    public void MainMenu()
    {
        StartCoroutine(LoadScene(0));
    }

    public bool IsPaused()
    {
        return isPaused;
    }

    public void Pause()
    {
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        ShowPauseMenu();
    }

    private void ShowPauseMenu()
    {
        pauseMenuPanel.SetActive(true);
    }

    private void HidePauseMenu()
    {
        pauseMenuPanel.SetActive(false);
    }

    private IEnumerator LoadScene(int buildIndex)
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(buildIndex);
    }
}
