using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudControl : MonoBehaviour {
    public Sprite[] theClouds;
    private SpriteRenderer spriteRenderer;
    private int randomNum;
    private Vector3 startPos;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        randomNum = UnityEngine.Random.Range(0, 2);
        startPos = transform.position;
        startPos.y = -1.3f;
        spriteRenderer.sprite = theClouds[randomNum];

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
