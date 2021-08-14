using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    private GameObject pauseMenuPanel;
    private AudioSource inGameBackgroundMusic;
    private GameObject character;

    void Start()
    {
        Canvas canvas = FindObjectOfType<Canvas>();
        pauseMenuPanel = canvas.transform.Find("PauseMenu").gameObject;
        inGameBackgroundMusic = GameObject.Find("InGameBackgroundMusic").GetComponent<AudioSource>();
        character = GameObject.Find("character");
    }
    
    public void ResumeInMenu()
    {
        StartCoroutine(ResumeGame());
    }

    public void Resume()
    {
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inGameBackgroundMusic.UnPause();
        HidePauseMenu();
        character.SetActive(true);
    }

    public void MainMenu()
    {
        StartCoroutine(LoadMainMenu());
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
        inGameBackgroundMusic.Pause();
        ShowPauseMenu();
        character.SetActive(false);
    }

    private void ShowPauseMenu()
    {
        pauseMenuPanel.SetActive(true);
    }

    private void HidePauseMenu()
    {
        pauseMenuPanel.SetActive(false);
    }

    private IEnumerator LoadMainMenu()
    {
        yield return new WaitForSeconds(0.75f);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.ResetAll();
        SceneManager.LoadScene(0);
    }
    
    private IEnumerator ResumeGame()
    {
        yield return new WaitForSeconds(0.75f);
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inGameBackgroundMusic.UnPause();
        HidePauseMenu();
        character.SetActive(true);
    }
}
