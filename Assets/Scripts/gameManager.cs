using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {


    public PlayerControl thePlayer;
    private Vector3 playerStartPoint;
    public scoreManager score;
    private Vector3 defaults;
    private Collider2D startBox;
    private Vector2 sizeDefaults;
    public bool beachSpawned;
    public bool desertSpawned;
    public bool greekSpawned;
	public GameObject Chicken;
    public bool forestSpawned;
    public string genSpawn;
	public string deathCause;
    public GameObject[] mountains;
    public GameObject[] fEnemies;
	public int chickenCounter = 1;
    public GameObject beachSpawner;
    public GameObject theCamera;
    public GameObject desertSpawner;
    private int xPos;
    public GameObject greekSpawner;
    private int skyCounter = 0;
    private int mountainCounter = 0;
    private int skyCounter2 = 0;
    private int mountainCounter2 = 0;
    public GameObject forestSpawner;
    public bool isDead = false;
    private int eCounter = 0;
    public GameObject crow;
    private int fullLoop;
    public GameObject seagull;
    public GameObject sky;
    public GameObject scorpion;
    private Vector3 startPos = new Vector3(17.58f, 0.52f, 0);
    public GameObject vulture;
    public int counter;
    public GameObject[] bEnemies;
    public GameObject[] dEnemies;
    public GameObject crab;
    public GameObject[] fDefault;
    public GameObject[] fGen;
    public GameObject[] dDefault;
    public int timeCounter;
    public GameObject[] dGen;
    public GameObject[] bDefault;
    public GameObject[] bGen;
    public GameObject[] gDefault;
    public GameObject[] gGen;
    public int[] randomNumbers;

    // Use this for initialization
    void Start () {
        genSpawn = "Forest";
        generateWorld();
        generateSky();
	//	generateChickens();
       // generateMountain();
       // spawnEnemies();
        beachSpawned = false;
        desertSpawned = false;
        playerStartPoint = thePlayer.transform.position;
        startBox = thePlayer.myCollider;
        sizeDefaults = thePlayer.GetComponent<BoxCollider2D>().size;
       // beachSpawner = GameObject.Find("beachSpawnPoint");
      //  desertSpawner = GameObject.Find("desertSpawnPoint");
       // greekSpawner = GameObject.Find("greekSpawnPoint");
        //forestSpawner = GameObject.Find("forestSpawnPoint");
        
    }

    // Update is called once per frame
    void Update() {
       // Debug.Log("Player Position" + thePlayer.transform.position.x);
        xPos = (int)Math.Floor(thePlayer.transform.position.x);
   //    Debug.Log("Player Position UPDATED woo:" + xPos);

  //      timeCounter = timeCounter + 1;
        if (xPos % 750 == 0)
        {
     //       Debug.Log("Generating More Worlds.");
            mountainCounter2 = 0;
            skyCounter2 = 0;
            generateWorld();
            generateSky();
			//generateChickens();
         //   generateMountain();
            xPos = xPos + 1;
        }
        if (thePlayer.transform.position.x >= 0)
        {
            isDead = false;
            //im just confused ok

        }
        //beachSpawner = GameObject.Find("beachSpawnPoint");
      //  desertSpawner = GameObject.Find("desertSpawnPoint");
       // greekSpawner = GameObject.Find("greekSpawnPoint");
        //forestSpawner = GameObject.Find("forestSpawnPoint");
      /*  if (thePlayer.transform.position.x > beachSpawner.transform.position.x && beachSpawned == false && beachSpawner !=null)
        {
            beachSpawned = true;
            genSpawn = "Beach";
            generateWorld();

        }
        if (thePlayer.transform.position.x > desertSpawner.transform.position.x && desertSpawned == false && desertSpawner != null)
        {
            desertSpawned = true;
            genSpawn = "Desert";
            generateWorld();

        }
        if (thePlayer.transform.position.x > greekSpawner.transform.position.x && greekSpawned == false && greekSpawner != null)
        {
            greekSpawned = true;
            genSpawn = "Greek";
            generateWorld();

        }
        if (thePlayer.transform.position.x > forestSpawner.transform.position.x && forestSpawned == false && forestSpawner != null)
        {
            forestSpawned = true;
            genSpawn = "Forest";
            generateWorld();

        }*/
        
        /*  if (thePlayer.transform.position.x > desertSpawner.transform.position.x && desertSpawned == false)
          {
              eCounter = 0;
              while (eCounter <= 9)
              {
                  int distanceDif;
                  distanceDif = UnityEngine.Random.Range(35, 45);
                  if (eCounter == 0)
                  {
                      dEnemies[eCounter] = Instantiate(vulture, new Vector3(1032, 0.92f, 0), Quaternion.identity);
                  }
                  else
                  {
                      dEnemies[eCounter] = Instantiate(vulture, new Vector3(1032 + (distanceDif * eCounter), 0.92f, 0), Quaternion.identity);


                  }
                  eCounter = eCounter + 1;
              }
              while (eCounter == 10)
              {
                  int distanceDif;
                  distanceDif = UnityEngine.Random.Range(1032, 1074);
                  dEnemies[eCounter] = Instantiate(scorpion, new Vector3(distanceDif, 0.92f, 0), Quaternion.identity);
                  eCounter = eCounter + 1;


              }
              while (eCounter >= 11 && eCounter <= 13)
              {

                  int dif;
                  dif = UnityEngine.Random.Range(70,80);


                  if (eCounter == 11)
                  {
                      dEnemies[eCounter] = Instantiate(scorpion, new Vector3(1082 + dif, 0.92f, 0), Quaternion.identity);
                  }
                  if (eCounter == 12)
                  {
                      dEnemies[eCounter] = Instantiate(scorpion, new Vector3(1082 + dif * 2, 0.92f, 0), Quaternion.identity);
                  }
                  if (eCounter == 13)
                  {
                      dEnemies[eCounter] = Instantiate(scorpion, new Vector3(1082 + dif * 3, 0.92f, 0), Quaternion.identity);
                  }
                  eCounter = eCounter + 1;

              }
              if (eCounter == 14)
              {
                  int dif;
                  dif = UnityEngine.Random.Range(40, 45);
                  dEnemies[eCounter] = Instantiate(scorpion, new Vector3(1342 + dif, 0.92f, 0), Quaternion.identity);


              }
              if (eCounter == 15)
              {
                  int dif;
                  dif = UnityEngine.Random.Range(40, 45);
                  dEnemies[eCounter] = Instantiate(scorpion, new Vector3(1342 + dif * 2, 0.92f, 0), Quaternion.identity);

              }
              desertSpawned = true;


          }
          if (thePlayer.transform.position.x > beachSpawner.transform.position.x && beachSpawned == false)
          {
              eCounter = 0;
              while (eCounter <=4)
              {
                  Debug.Log("Enemy Counter:" + eCounter);
                  int distanceDif;
                  distanceDif = UnityEngine.Random.Range(90, 100);
                  if (eCounter == 0)
                  {
                      bEnemies[eCounter] = Instantiate(seagull, new Vector3(550, -0.2f, 0), Quaternion.identity);
                  }
                  else
                  {
                      bEnemies[eCounter] = Instantiate(seagull, new Vector3(550 + (distanceDif * eCounter), -0.2f, 0), Quaternion.identity);


                  }
                  eCounter = eCounter + 1;


              }
           //   eCounter = 0;
              while (eCounter <= 10)
              {
                  int distanceDif;
                  if (eCounter == 5)
                  {
                      distanceDif = UnityEngine.Random.Range(530, 560);
                      bEnemies[eCounter] = Instantiate(crab, new Vector3(distanceDif, -0.2f, 0), Quaternion.identity);

                  }

                  if (eCounter == 6)
                  {
                      distanceDif = UnityEngine.Random.Range(40, 50);

                      bEnemies[eCounter] = Instantiate(crab, new Vector3(600 + distanceDif, -0.2f, 0), Quaternion.identity);
                  }
                  if (eCounter == 7)
                  {
                      distanceDif = UnityEngine.Random.Range(40, 50);

                      bEnemies[eCounter] = Instantiate(crab, new Vector3(650 + distanceDif, -0.2f, 0), Quaternion.identity);
                  }
                  if (eCounter == 8)
                  {
                      distanceDif = UnityEngine.Random.Range(40, 50);

                      bEnemies[eCounter] = Instantiate(crab, new Vector3(700 + distanceDif, -0.2f, 0), Quaternion.identity);
                  }
                  if (eCounter == 9)
                  {
                      distanceDif = UnityEngine.Random.Range(816, 838);
                      bEnemies[eCounter] = Instantiate(crab, new Vector3(distanceDif, -0.2f, 0), Quaternion.identity);
                  }
                  if (eCounter == 10)
                  {
                      distanceDif = UnityEngine.Random.Range(1012, 1028);
                      bEnemies[eCounter] = Instantiate(crab, new Vector3(distanceDif, -0.2f, 0), Quaternion.identity);
                  }
                  eCounter = eCounter + 1;

              }
              beachSpawned = true;

          }*/

    }

    /* public void spawnEnemies()
     {
        // Debug.Log("hi");
         while (eCounter <= 5)
         {
             Debug.Log("IsThisWorking?");
             int distanceDif;
             //550-1000
             distanceDif = UnityEngine.Random.Range(80, 90);
             if (eCounter == 0)
             {
               //  fEnemies[eCounter] = Instantiate(crow, new Vector3(25, -0.2f, 0), Quaternion.identity);
             }
             else
             {
                 fEnemies[eCounter] = Instantiate(crow, new Vector3(35 + (distanceDif * eCounter), -0.2f, 0), Quaternion.identity);


             }
             eCounter = eCounter + 1;
         }

     }
     public void killEnemies()
     {
        // Debug.Log("hi");

         eCounter = 0;
         while (eCounter <=9)
         {
             Destroy(fEnemies[eCounter]);
             eCounter = eCounter + 1;
         }
         eCounter = 0;
         while (eCounter <= 10)
         {
             Destroy(bEnemies[eCounter]);
             eCounter = eCounter + 1;

         }
         eCounter = 0;
         while (eCounter <= 9)
         {
             Destroy(dEnemies[eCounter]);
             eCounter = eCounter + 1;

         }


     }
     */
     public void generateSky()
    {
      //  Debug.Log("IS sky being generated???");
        while (skyCounter2 <= 75)
        {
        //    Debug.Log("IS sky being generated???");
            if (skyCounter == 0)
            {
                Instantiate(sky, new Vector3(17.58f, -1.32f, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(sky, new Vector3(17.58f + sky.gameObject.GetComponent<SpriteRenderer>().bounds.size.x * skyCounter, -1.32f, 0), Quaternion.identity);

            }
            skyCounter2 = skyCounter + 1;
            skyCounter = skyCounter + 1;

        }
    }
	public void generateChickens()
	{
		while (chickenCounter <= 13) {

			Instantiate(Chicken, new Vector3((UnityEngine.Random.Range(100,150) * chickenCounter ) , 3), Quaternion.identity);
			chickenCounter = chickenCounter + 1;
		}

	}
    public void generateMountain()
    {
       // Debug.Log("IS sky being generated???");
        while (mountainCounter2 <= 75)
        {
         //   Debug.Log("IS sky being generated???");
            if (mountainCounter == 0)
            {
                Instantiate(mountains[UnityEngine.Random.Range(0,5)], new Vector3(17.58f, -0.9f, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(mountains[UnityEngine.Random.Range(0, 5)], new Vector3(17.58f + mountains[0].gameObject.GetComponent<SpriteRenderer>().bounds.size.x * mountainCounter, -0.9f, 0), Quaternion.identity);

            }
            mountainCounter = mountainCounter + 1;
            mountainCounter2 = mountainCounter2 + 1;

        }
    }
    public void generateWorld()
    {
        while (counter < 5)
        {
         //   Debug.Log("Counter: " + counter);
           randomNumbers[counter] = UnityEngine.Random.Range(0, 10);
            if (counter == 0 && fullLoop == 0)
            {
                  //GameObject foreststart = ObjectPooler.SharedInstance.GetPooledObject("Forest1(Clone)");
                   //Debug.Log("Testing pooler:" + ObjectPooler.SharedInstance.GetPooledObject("Forest1(Clone)"));
                  //foreststart.SetActive(true);
                //foreststart.transform.position = startPos;
                   fGen[0] = Instantiate(fDefault[0], new Vector3(17.58f, 0.52f, 0), Quaternion.identity);
                //fGen[0] = foreststart;
            }
            if (counter == 0 && fullLoop == 1)
            {

                //fGen[0] = Instantiate(fDefault[0], new Vector3(17.58f, 0.52f, 0), Quaternion.identity);
                fGen[0] = Instantiate(fDefault[randomNumbers[counter]], gGen[3].transform.position + (gGen[3].transform.right * (gGen[3].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + fDefault[randomNumbers[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), gGen[3].transform.rotation);

            }
            if (counter >= 1 && counter != 4)
            {
             //   int randomValue = UnityEngine.Random.Range(2, 13);
               // while (randomValue == 1|| randomValue == 8)
                //{

                  //  randomValue = UnityEngine.Random.Range(2, 13);
               // }
                 // GameObject forestContinue = ObjectPooler.SharedInstance.GetPooledObject("Forest" + randomValue + "(Clone)");
                 // Debug.Log(ObjectPooler.SharedInstance.GetPooledObject("Forest" + randomValue + "(Clone)"));
                 //forestContinue.SetActive(true);
                //startPos.x = fGen[counter - 1].transform.position.x + fGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2;
                //forestContinue.transform.position = startPos;
                // Debug.Log(fGen[counter - 1].gameObject.GetComponent < SpriteRenderer<>().bounds.size.x / 2);
                   fGen[counter] = Instantiate(fDefault[randomNumbers[counter]], fGen[counter - 1].transform.position + (fGen[counter - 1].transform.right * (fGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + fDefault[randomNumbers[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), fDefault[counter - 1].transform.rotation);
                //fGen[counter] = forestContinue;

            }
            if (counter == 4)   
            {
				fGen[counter] = Instantiate(fDefault[11], fGen[counter - 1].transform.position + (fGen[counter - 1].transform.right * ((fGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2) - 1 + fDefault[11].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), fDefault[counter - 1].transform.rotation);
                beachSpawner = GameObject.Find("beachSpawnpoint");
             
          

            }
            counter = counter + 1;

        }
        counter = 0;
       while (counter < 4)
        {
            randomNumbers[counter] = UnityEngine.Random.Range(0, 4);
           // Debug.Log("Testing:" + counter + beachScenes[counter]);
            if (counter == 0)
            {
              //  Debug.Log("Testing: " + forest[11].transform.position.x);
                bGen[0] = Instantiate(bDefault[randomNumbers[counter]], fGen[4].transform.position + (fGen[4].transform.right * (fGen[4].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + bDefault[randomNumbers[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), fGen[4].transform.rotation);



            }
            if (counter >= 1 && counter < 3)
            {
                bGen[counter] = Instantiate(bDefault[randomNumbers[counter]], bGen[counter - 1].transform.position + (bGen[counter - 1].transform.right * (bGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + bDefault[randomNumbers[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), bDefault[counter - 1].transform.rotation);


            }
            if (counter == 3)
            {
                bGen[counter] = Instantiate(bDefault[4], bGen[counter - 1].transform.position + (bGen[counter - 1].transform.right * (bGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + bDefault[4].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), bDefault[counter - 1].transform.rotation);
                desertSpawner = GameObject.Find("desertSpawnPoint");

            }
            counter = counter + 1;

        }
        counter = 0;
        while (counter < 4)
        {
            randomNumbers[counter] = UnityEngine.Random.Range(0, 4);
            // Debug.Log("Testing:" + counter + beachScenes[counter]);
            if (counter == 0)
            {
                //  Debug.Log("Testing: " + forest[11].transform.position.x);
                dGen[0] = Instantiate(dDefault[randomNumbers[counter]], bGen[3].transform.position + (bGen[3].transform.right * (bGen[3].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + dDefault[randomNumbers[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), bGen[3].transform.rotation);



            }
            if (counter >= 1 && counter < 3)
            {
                dGen[counter] = Instantiate(dDefault[randomNumbers[counter]], dGen[counter - 1].transform.position + (dGen[counter - 1].transform.right * (dGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + dDefault[randomNumbers[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), dDefault[counter - 1].transform.rotation);


            }
            if (counter == 3)
            {
                dGen[counter] = Instantiate(dDefault[4], dGen[counter - 1].transform.position + (dGen[counter - 1].transform.right * (dGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + dDefault[4].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), dDefault[counter - 1].transform.rotation);
                greekSpawner = GameObject.Find("greekSpawnPoint");


            }
            counter = counter + 1;

        }
        counter = 0;
        while (counter < 4)
        {
            randomNumbers[counter] = UnityEngine.Random.Range(0, 4);
            // Debug.Log("Testing:" + counter + beachScenes[counter]);
            if (counter == 0)
            {
                //  Debug.Log("Testing: " + forest[11].transform.position.x);
                gGen[0] = Instantiate(gDefault[randomNumbers[counter]], dGen[3].transform.position + (dGen[3].transform.right * (dGen[3].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + gDefault[randomNumbers[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), dGen[3].transform.rotation);



            }
            if (counter >= 1 && counter < 3)
            {
                gGen[counter] = Instantiate(gDefault[randomNumbers[counter]], gGen[counter - 1].transform.position + (gGen[counter - 1].transform.right * (gGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + gDefault[randomNumbers[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), gDefault[counter - 1].transform.rotation);


            }
            if (counter == 3)
            {
                gGen[counter] = Instantiate(gDefault[4], gGen[counter - 1].transform.position + (gGen[counter - 1].transform.right * (gGen[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + gDefault[4].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), gDefault[counter - 1].transform.rotation);
                greekSpawned = false;
                forestSpawned = false;
                desertSpawned = false;
                beachSpawned = false;
                fullLoop = 1;
                forestSpawner = GameObject.Find("forestSpawnPoint");


            }
            counter = counter + 1;

        }
        counter = 0;

    }
    public void killWorld()
    {
        fullLoop = 0;
        GameObject[] objects = GameObject.FindGameObjectsWithTag("world");

        for (int i = 0; i < objects.Length; i++)
        {
            Destroy(objects[i]);
        }

    }

    public void restartGame()
    {
        StartCoroutine("RestartGameCo");

    }

    public IEnumerator RestartGameCo()
    {
        isDead = true;
        killWorld();
        //killEnemies();
        eCounter = 0;
        //  spawnEnemies();
        genSpawn = "Forest";
        beachSpawned = false;
        desertSpawned = false;
        score.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);
        score.lives = score.lives - 1;
        if (score.lives <= -90)
        {
            //Debug.Log("yes");
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

        }
        else
        {
            thePlayer.transform.position = playerStartPoint;
            thePlayer.GetComponent<BoxCollider2D>().size = sizeDefaults;

            thePlayer.speed = 10;
            thePlayer.speedMulti = thePlayer.speedStore;
            thePlayer.milestone = thePlayer.milestoneStore;
            thePlayer.milestoneCount = thePlayer.milestonecountStore;
            score.score = 0;
			score.chickens = 0;
            score.scoreIncreasing = true;
            thePlayer.isduck = false;
            thePlayer.duckManager.duck = false;
            mountainCounter = 0;
            skyCounter2 = 0;
            mountainCounter2 = 0;
			chickenCounter = 1;
            skyCounter = 0;
            generateSky();
		//	generateChickens ();
         //   generateMountain();
            yield return new WaitForSeconds(0.5f);

            thePlayer.gameObject.SetActive(true);
			generateWorld();




        }
        //      thePlayer.transform.localScale = new Vector3(0.37, 0.37, 0.37);


    }
}
