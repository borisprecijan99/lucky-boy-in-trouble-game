using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        StartCoroutine(LoadFirstLevel());
    }

    public void Quit()
    {
        StartCoroutine(QuitGame());
    }

    private IEnumerator LoadFirstLevel()
    {
        yield return new WaitForSeconds(0.75f);
        SceneManager.LoadScene(1);
    }

    private IEnumerator QuitGame()
    {
        yield return new WaitForSeconds(0.75f);
        Application.Quit();
    }
}
