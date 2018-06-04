using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	public PlayerControl thePlayer;
	private scoreManager theScore;

	// Use this for initialization
	void Start () {
		theScore = FindObjectOfType<scoreManager>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D other)

	{
		if (other.gameObject.name == "Player")
		{
		theScore.addScore(5);
			theScore.chickens = theScore.chickens + 1;

			this.transform.parent.gameObject.SetActive (false);

		}

		if (other.gameObject.tag == "killbox") 
		{
			//  Debug.Log("testing");
			this.transform.parent.gameObject.SetActive (false);

		}
		if (other.gameObject.tag == "water") 
		{
			//  Debug.Log("testing");
			this.transform.parent.gameObject.SetActive (false);

		}

}
}