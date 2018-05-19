using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stationary : MonoBehaviour {

    public float speed;
    public Rigidbody2D myRigidbody;
    private Vector3 startPos;
    private int spawnValue;
    // Use this for initialization
    void Start()    
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        spawnValue = Random.Range(-2, 2);
        startPos.x = startPos.x + spawnValue;
          transform.position = startPos;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
