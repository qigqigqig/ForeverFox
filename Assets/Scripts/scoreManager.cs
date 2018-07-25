using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
    public Text scoreText;
    public Text hiText;
	public gameManager theGameManager;

	public Text deathText;
    public float score;
	public int chickens;
    public float hiscore;
    public float pointsPerSecond;
    public int laps = 0;
    public bool scoreIncreasing;
    public int lives;
    public Text livesText;
	public Text chickenText;


	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetFloat ("HighScore") != null) {

			hiscore = PlayerPrefs.GetFloat ("HighScore");
		}
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreIncreasing)
        {
            score += pointsPerSecond * Time.deltaTime;
        }
        
        if (score > hiscore)
        {
            hiscore = score;
			PlayerPrefs.SetFloat("HighScore", hiscore);

        }

        scoreText.text = "Score: " + Mathf.Round(score);
        hiText.text = "High Score: " + Mathf.Round(hiscore);
        livesText.text = " " + lives;
		deathText.text = "Death Cause: " + theGameManager.deathCause;
		chickenText.text = " " + chickens;
    }

    public void addScore(int value)
    {
        if (laps >= 1)
        {
            score = score + value + (laps * 5);
        }
        else
        {
            score += value;
        }
    }
}
