using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forestSpawner : MonoBehaviour
{
    public gameManager theGameManager;
    public scoreManager theScoreManager;
    // Use this for initialization
    void Start()
    {
        theGameManager = FindObjectOfType<gameManager>();
        theScoreManager = FindObjectOfType<scoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player" && this.gameObject.name == "generateforest")
        {
            //            Debug.Log("reee");
            theGameManager.skyCounter2 = 0;
            theGameManager.mountainCounter2 = 0;
            theGameManager.generateForest();
            theGameManager.generateSky();
        


        }
        if (other.gameObject.name == "Player" && this.gameObject.name == "generatebeach")
        {
            //            Debug.Log("reee");
            theGameManager.skyCounter2 = 0;
            theGameManager.mountainCounter2 = 0;
            theGameManager.generateBeach();
            theGameManager.generateSky();



        }
        if (other.gameObject.name == "Player" && this.gameObject.name == "generatedesert")
        {
            //            Debug.Log("reee");
            theGameManager.skyCounter2 = 0;
            theGameManager.mountainCounter2 = 0;
            theGameManager.generateDesert();
            theGameManager.generateSky();



        }
        if (other.gameObject.name == "Player" && this.gameObject.name == "generategreek")
        {
            //            Debug.Log("reee");
            theScoreManager.laps = theScoreManager.laps + 1;

            theGameManager.skyCounter2 = 0;
            theGameManager.mountainCounter2 = 0;
            theGameManager.generateGreek();
            theGameManager.generateSky();


        }
    }
}
