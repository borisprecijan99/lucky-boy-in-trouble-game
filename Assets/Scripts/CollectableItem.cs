using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        switch (tag)
        {
            case "carrotCollectable":
                gameManager.IncreaseCollectedNumberOfCarrots();
                break;
            case "appleCollectable":
                gameManager.IncreaseCollectedNumberOfApples();
                break;
            case "bananaCollectable":
                gameManager.IncreaseCollectedNumberOfBananas();
                break;
            case "cherryCollectable":
                gameManager.IncreaseCollectedNumberOfCherries();
                break;
            case "avocadoCollectable":
                gameManager.IncreaseCollectedNumberOfAvocados();
                break;
            case "tomatoCollectable":
                gameManager.IncreaseCollectedNumberOfTomatoes();
                break;
            case "pineappleCollectable":
                gameManager.IncreaseCollectedNumberOfPineapples();
                break;
            case "watermelonCollectable":
                gameManager.IncreaseCollectedNumberOfWatermelons();
                break;
        }
        GameObject.FindObjectOfType<AudioManager>().PlayIfIsPlaying("collectableItem");
        gameManager.GetListOfCollectedItems().Add(gameObject.name);
        Destroy(gameObject);
    }
}
