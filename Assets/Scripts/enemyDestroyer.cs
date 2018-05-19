using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroyer : MonoBehaviour {
    public GameObject enemyDestroyerPoint;
	// Use this for initialization
	void Start () {
        enemyDestroyerPoint = GameObject.Find("edp");
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < enemyDestroyerPoint.transform.position.x)
        {

            Destroy(gameObject);
        }
		
	}
}
