using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mountains : MonoBehaviour {
	public Sprite[] theMountains;
	private SpriteRenderer spriteRenderer;
	private int randomNum;
	private Vector3 startPos;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		randomNum = UnityEngine.Random.Range (0,5);
		startPos = transform.position;
		startPos.y = -1.3f;
		spriteRenderer.sprite = theMountains[randomNum];
		//if (randomNum == 3 || randomNum == 4 ) {

			this.transform.position = startPos;
		
		
		//}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
