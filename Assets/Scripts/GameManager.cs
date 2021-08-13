using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private PauseMenu pauseMenu;

    private static int level;
    private static int lives;

    private static int totalNumberOfCarrots;
    private static int collectedNumberOfCarrots;

    private static int totalNumberOfApples;
    private static int collectedNumberOfApples;

    private static int totalNumberOfBananas;
    private static int collectedNumberOfBananas;

    private static int totalNumberOfWatermelons;
    private static int collectedNumberOfWatermelons;

    private static int totalNumberOfCherries;
    private static int collectedNumberOfCherries;

    private static int totalNumberOfPineapples;
    private static int collectedNumberOfPineapples;

    private static int totalNumberOfAvocados;
    private static int collectedNumberOfAvocados;

    private static int totalNumberOfTomatoes;
    private static int collectedNumberOfTomatoes;

    private static List<string> listOfCollectedItems;

    static GameManager()
    {
        InitializeVariables();
    }

    void Start()
    {
        totalNumberOfCarrots = GameObject.FindGameObjectsWithTag("carrotCollectable").Length;
        totalNumberOfApples = GameObject.FindGameObjectsWithTag("appleCollectable").Length;
        totalNumberOfBananas = GameObject.FindGameObjectsWithTag("bananaCollectable").Length;
        totalNumberOfAvocados = GameObject.FindGameObjectsWithTag("avocadoCollectable").Length;
        totalNumberOfCherries = GameObject.FindGameObjectsWithTag("cherryCollectable").Length;
        totalNumberOfWatermelons = GameObject.FindGameObjectsWithTag("watermelonCollectable").Length;
        totalNumberOfTomatoes = GameObject.FindGameObjectsWithTag("tomatoCollectable").Length;
        totalNumberOfPineapples = GameObject.FindGameObjectsWithTag("pineappleCollectable").Length;

        if (listOfCollectedItems == null)
        {
            listOfCollectedItems = new List<string>();
        }
        else
        {
            if (listOfCollectedItems.Capacity > 0)
            {
                foreach (string name in listOfCollectedItems)
                {
                    Destroy(GameObject.Find(name));
                }
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pauseMenu.IsPaused())
            {
                pauseMenu.Pause();
            }
            else
            {
                pauseMenu.Resume();
            }
        }
    }

    private static void InitializeVariables()
    {
        level = 1;
        lives = 5;
        collectedNumberOfCarrots = 0;
        collectedNumberOfApples = 0;
        collectedNumberOfBananas = 0;
        collectedNumberOfAvocados = 0;
        collectedNumberOfCherries = 0;
        collectedNumberOfWatermelons = 0;
        collectedNumberOfTomatoes = 0;
        collectedNumberOfPineapples = 0;
    }

    private bool IsSceneExists(int buildIndex)
    {
        int lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        if (buildIndex <= lastSceneIndex)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void LoadNextLevel()
    {
        level++;
        if (IsSceneExists(level))
        {
            if (IsAllCollected())
            {
                lives++;
            }
            SceneManager.LoadScene(level);
        }
        else
        {
            InitializeVariables();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(0);
        }
    }

    public void RestartCurrentLevelOrLoadMainMenu()
    {
        lives--;
        if (lives == 0)
        {
            /*level = 1;
            lives = 5;
            listOfCollectedItems.Clear();*/
            //fali i reset vrednosti za voce i povrce!!!
            InitializeVariables();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private bool IsAllCollected()
    {
        bool carrots = collectedNumberOfCarrots == totalNumberOfCarrots;
        bool apples = collectedNumberOfApples == totalNumberOfApples;
        bool bananas = collectedNumberOfBananas == totalNumberOfBananas;
        bool cherries = collectedNumberOfCherries == totalNumberOfCherries;
        bool watermelons = collectedNumberOfWatermelons == totalNumberOfWatermelons;
        bool pineapples = collectedNumberOfPineapples == totalNumberOfPineapples;
        bool avocados = collectedNumberOfAvocados == totalNumberOfAvocados;
        bool tomatoes = collectedNumberOfTomatoes == totalNumberOfTomatoes;
        return carrots && apples && bananas && cherries && watermelons && pineapples && avocados && tomatoes;
    }

    public List<string> GetListOfCollectedItems()
    {
        return listOfCollectedItems;
    }

    public int GetLevel()
    {
        return level;
    }

    public int GetLives()
    {
        return lives;
    }

    public int GetTotalNumberOfCarrots()
    {
        return totalNumberOfCarrots;
    }

    public int GetCollectedNumberOfCarrots()
    {
        return collectedNumberOfCarrots;
    }

    public void IncreaseCollectedNumberOfCarrots()
    {
        collectedNumberOfCarrots++;
    }

    public int GetTotalNumberOfApples()
    {
        return totalNumberOfApples;
    }

    public int GetCollectedNumberOfApples()
    {
        return collectedNumberOfApples;
    }

    public void IncreaseCollectedNumberOfApples()
    {
        collectedNumberOfApples++;
    }

    public int GetTotalNumberOfBananas()
    {
        return totalNumberOfBananas;
    }

    public int GetCollectedNumberOfBananas()
    {
        return collectedNumberOfBananas;
    }

    public void IncreaseCollectedNumberOfBananas()
    {
        collectedNumberOfBananas++;
    }

    public int GetTotalNumberOfAvocados()
    {
        return totalNumberOfAvocados;
    }

    public int GetCollectedNumberOfAvocados()
    {
        return collectedNumberOfAvocados;
    }

    public void IncreaseCollectedNumberOfAvocados()
    {
        collectedNumberOfAvocados++;
    }

    public int GetTotalNumberOfCherries()
    {
        return totalNumberOfCherries;
    }

    public int GetCollectedNumberOfCherries()
    {
        return collectedNumberOfCherries;
    }

    public void IncreaseCollectedNumberOfCherries()
    {
        collectedNumberOfCherries++;
    }

    public int GetTotalNumberOfWatermelons()
    {
        return totalNumberOfWatermelons;
    }

    public int GetCollectedNumberOfWatermelons()
    {
        return collectedNumberOfWatermelons;
    }

    public void IncreaseCollectedNumberOfWatermelons()
    {
        collectedNumberOfWatermelons++;
    }

    public int GetTotalNumberOfTomatoes()
    {
        return totalNumberOfTomatoes;
    }

    public int GetCollectedNumberOfTomatoes()
    {
        return collectedNumberOfTomatoes;
    }

    public void IncreaseCollectedNumberOfTomatoes()
    {
        collectedNumberOfTomatoes++;
    }

    public int GetTotalNumberOfPineapples()
    {
        return totalNumberOfPineapples;
    }

    public int GetCollectedNumberOfPineapples()
    {
        return collectedNumberOfPineapples;
    }

    public void IncreaseCollectedNumberOfPineapples()
    {
        collectedNumberOfPineapples++;
    }
}
