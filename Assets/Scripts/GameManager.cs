using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private MainMenu mainMenu;
    private PauseMenu pauseMenu;
    private static int level;
    private static int totalNumberOfCarrots;
    private static int collectedNumberOfCarrots;

    private static int totalNumberOfApples;
    private static int collectedNumberOfApples;

    private static int totalNumberOfBananas;
    private static int collectedNumberOfBananas;
    private static int score;
    private static int lives;
    public static List<GameObject> listOfCollectedItems;

    static GameManager()
    {
        level = 1;
        score = 0;
        lives = 5;
        collectedNumberOfCarrots = 0;
        collectedNumberOfApples = 0;
        collectedNumberOfBananas = 0;
        listOfCollectedItems = new List<GameObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
        totalNumberOfCarrots = GameObject.FindGameObjectsWithTag("carrotCollectable").Length;
        totalNumberOfApples = GameObject.FindGameObjectsWithTag("appleCollectable").Length;
        Debug.Log("Number of carrots on scene: " + totalNumberOfCarrots);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static int GetScore()
    {
        return score;
    }

    public static int GetLevel()
    {
        return level;
    }

    public static void IncreaseScore(int s)
    {
        score += s;
    }

    public static void IncreaseLives()
    {
        lives++;
    }

    public static int GetTotalNumberOfCarrots()
    {
        return totalNumberOfCarrots;
    }

    public static int GetCollectedNumberOfCarrots()
    {
        return collectedNumberOfCarrots;
    }

    public static int GetTotalNumberOfApples()
    {
        return totalNumberOfApples;
    }

    public static int GetCollectedNumberOfApples()
    {
        return collectedNumberOfApples;
    }
}
