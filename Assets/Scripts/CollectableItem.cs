using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        //GameManager.pokupljeno.Find(go => go.name == gameObject.name);
        switch (tag)
        {
            case "carrotCollectable":
                
                break;
            case "appleCollectable":

                break;
            case "bananaCollectable":

                break;
            case "cherryCollectable":

                break;
            case "avocadoCollectable":

                break;
            case "tomatoCollectable":

                break;
            case "pineappleCollectable":

                break;
            case "watermelonCollectable":

                break;
        }
        Destroy(gameObject);
    }
}
