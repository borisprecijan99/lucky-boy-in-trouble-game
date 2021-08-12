using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    private GameManager gameManager;
    private TMP_Text lives;
    private TMP_Text level;
    private TMP_Text apples;
    private TMP_Text bananas;
    private TMP_Text carrots;
    private TMP_Text watermelons;
    private TMP_Text cherries;
    private TMP_Text pineapples;
    private TMP_Text tomatoes;
    private TMP_Text avocados;
    private Canvas canvas;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        canvas = GetComponent<Canvas>();
        Transform childLives = canvas.transform.Find("lives");
        Transform childLevel = canvas.transform.Find("level");
        Transform childTomatoes = canvas.transform.Find("numberOfTomatoes");
        Transform childApples = canvas.transform.Find("numberOfApples");
        Transform childBananas = canvas.transform.Find("numberOfBananas");
        Transform childCarrots = canvas.transform.Find("numberOfCarrots");
        Transform childPineapples = canvas.transform.Find("numberOfPineapples");
        Transform childCherries = canvas.transform.Find("numberOfCherries");
        Transform childWatermelons = canvas.transform.Find("numberOfWatermelons");
        Transform childAvocados = canvas.transform.Find("numberOfAvocados");

        lives = childLives.GetComponent<TMP_Text>();
        level = childLevel.GetComponent<TMP_Text>();
        bananas = childBananas.GetComponent<TMP_Text>();
        apples = childApples.GetComponent<TMP_Text>();
        tomatoes = childTomatoes.GetComponent<TMP_Text>();
        carrots = childCarrots.GetComponent<TMP_Text>();
        pineapples = childPineapples.GetComponent<TMP_Text>();
        cherries = childCherries.GetComponent<TMP_Text>();
        watermelons = childWatermelons.GetComponent<TMP_Text>();
        avocados = childAvocados.GetComponent<TMP_Text>();
    }

    void Update()
    {
        int lives = gameManager.GetLives();
        int level = gameManager.GetLevel();

        int totalNumberOfBananas = gameManager.GetTotalNumberOfBananas();
        int collectedNumberOfBananas = gameManager.GetCollectedNumberOfBananas();

        int totalNumberOfApples = gameManager.GetTotalNumberOfApples();
        int collectedNumberOfApples = gameManager.GetCollectedNumberOfApples();

        int totalNumberOfTomatoes = gameManager.GetTotalNumberOfTomatoes();
        int collectedNumberOfTomatoes = gameManager.GetCollectedNumberOfTomatoes();

        int totalNumberOfCarrots = gameManager.GetTotalNumberOfCarrots();
        int collectedNumberOfCarrots = gameManager.GetCollectedNumberOfCarrots();

        int totalNumberOfWatermelons = gameManager.GetTotalNumberOfWatermelons();
        int collectedNumberOfWatermelons = gameManager.GetCollectedNumberOfWatermelons();

        int totalNumberOfAvocados = gameManager.GetTotalNumberOfAvocados();
        int collectedNumberOfAvocados = gameManager.GetCollectedNumberOfAvocados();

        int totalNumberOfCherries = gameManager.GetTotalNumberOfCherries();
        int collectedNumberOfCherries = gameManager.GetCollectedNumberOfCherries();

        int totalNumberOfPineapples = gameManager.GetTotalNumberOfPineapples();
        int collectedNumberOfPineapples = gameManager.GetCollectedNumberOfPineapples();

        this.lives.SetText("Lives: " + lives);
        this.level.SetText("Level: " + level);
        this.bananas.SetText(collectedNumberOfBananas + "/" + totalNumberOfBananas);
        this.apples.SetText(collectedNumberOfApples + "/" + totalNumberOfApples);
        this.tomatoes.SetText(collectedNumberOfTomatoes + "/" + totalNumberOfTomatoes);
        this.carrots.SetText(collectedNumberOfCarrots + "/" + totalNumberOfCarrots);
        this.pineapples.SetText(collectedNumberOfPineapples + "/" + totalNumberOfPineapples);
        this.cherries.SetText(collectedNumberOfCherries + "/" + totalNumberOfCherries);
        this.watermelons.SetText(collectedNumberOfWatermelons + "/" + totalNumberOfWatermelons);
        this.avocados.SetText(collectedNumberOfAvocados + "/" + totalNumberOfAvocados);
    }
}
