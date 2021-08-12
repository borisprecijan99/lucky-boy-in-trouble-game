using UnityEngine;

public class LoadNextLevel : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "character")
        {
            gameManager.LoadNextLevel();
        }
    }
}
