using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireflyScript : MonoBehaviour {

    private Rigidbody2D rb;
    private float yMax = 2.8f;
    private float yMin = -3.8f;
	private Vector3 hi;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
		hi = transform.position;
		hi.z = 3;
		transform.position = hi;
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y > yMax)
        {
            rb.velocity = new Vector2(rb.velocity.x, -0.1f);
        }
        if (transform.position.y < yMin)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0.1f);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x + Random.Range(-.1f, .1f), rb.velocity.y + Random.Range(-.1f, .1f));
        }
       
        
	}
}
