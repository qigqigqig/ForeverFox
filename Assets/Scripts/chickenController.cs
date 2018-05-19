using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenController : MonoBehaviour {
    public PlayerControl thePlayer;
    private scoreManager theScore;
    public int value;

	// Use this for initialization
	void Start () {
        theScore = FindObjectOfType<scoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
//     void OnTriggerEnter2D(Collider2D other)
//
//    {
//		if (other.Transform.GetChild(0).gameObject.name == "Player")
//        {
//            theScore.addScore(value);
//            gameObject.SetActive(false);
//
//        }
//
//		if (other.gameObject.tag == "killbox") 
//		{
//			//  Debug.Log("testing");
//			gameObject.SetActive(false);
//
//		}
//    }
}






