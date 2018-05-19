using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
    public Text scoreText;
    public Text hiText;
    public float score;
    public float hiscore;
    public float pointsPerSecond;
    public bool scoreIncreasing;
    public int lives;
    public Text livesText;


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
    }

    public void addScore(int value)
    {
        score += value;

    }
}
