using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    public float speed;
    public float jump;
    public bool grounded;
    public bool doubleJump = true;
    public Rigidbody2D myRigidbody;
    public LayerMask whatIsGround;
    public duckController duckManager;
    public Collider2D myCollider;
    private Vector2 lastPos;
    private Animator myAnimator;
    public gameManager theGameManager;
    public Transform groundCheck;
    public float checkRadius;
    public float speedMulti;
    public bool isduck;
    public float speedStore;
    public float milestone;
    public float milestoneStore;
    float speed2;
    public float milestoneCount;
    public float milestonecountStore;
    private int frame = 0;
    Vector2 currentPos;
    public GameObject[] forest;
    // crow x15-525 y-0.77 40-50 x difference
    public GameObject[] fEnemies;
    private int eCounter = 0;
    



    public int[] forestScenes;
    private int counter = 0;
   
    public GameObject[] beach, greek, desert;
    public int[] beachScenes, greekScenes, desertScenes;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
        myAnimator = GetComponent<Animator>();
        milestonecountStore = milestoneCount;
        milestoneStore = milestone;
        speedStore = speedMulti;
    

        //  Instantiate(Crow, new Vector3)
         /*while (counter < 6)
             {
             forestScenes[counter] = Random.Range(0, 10);
             if (counter == 0)
             {

                 forest[0] = Instantiate(forest[0], new Vector3(-20, 20, 0), Quaternion.identity);
             }
             if (counter >= 1 && counter != 5)
             {
                 forest[counter] = Instantiate(forest[forestScenes[counter]], forest[counter - 1].transform.position + (forest[counter - 1].transform.right * (forest[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + forest[forestScenes[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), forest[counter - 1].transform.rotation);


             }
             if (counter == 5)
             {
                 forest[counter] = Instantiate(forest[11], forest[counter - 1].transform.position + (forest[counter - 1].transform.right * (forest[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + forest[11].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), forest[counter - 1].transform.rotation);


             }
             counter = counter + 1;

         }
         counter = 0;
         while (counter < 4)
         {
             beachScenes[counter] = Random.Range(0, 4);
            Debug.Log("Testing:" + counter  + beachScenes[counter]);
             if (counter == 0)
             {
                 Debug.Log("Testing: " + forest[11].transform.position.x);
                 beach[0] = Instantiate(beach[beachScenes[counter]], forest[5].transform.position + (forest[5].transform.right * (forest[5].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + beach[beachScenes[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), forest[5].transform.rotation);



             }
              if (counter >= 1 && counter < 3)
             {
               beach[counter] = Instantiate(beach[beachScenes[counter]], beach[counter - 1].transform.position + (beach[counter - 1].transform.right * (beach[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + beach[beachScenes[counter]].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), beach[counter - 1].transform.rotation);


             }
              if (counter == 3)
             {
                 beach[counter] = Instantiate(beach[4], beach[counter - 1].transform.position + (beach[counter - 1].transform.right * (beach[counter - 1].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + beach[4].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2)), beach[counter - 1].transform.rotation);


             }
             counter = counter + 1;

         }*/

        // Instantiate(forest, new Vector3(-14, 11, 0), Quaternion.identity);
   //     forest[0] = Instantiate(forest[forestScenes[0]], new Vector3(-20, 20, 0), Quaternion.identity);
     //     Instantiate(forest[1], new Vector3( (forest[0].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2), 20, 0), Quaternion.identity);
       //  Debug.Log(forest[0].transform.right.x);
        //forest[1] = Instantiate(forest[2], forest[0].transform.position + (forest[0].transform.right * (forest[0].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2 + forest[2].gameObject.GetComponent<SpriteRenderer>().bounds.size.x / 2) ), forest[0].transform.rotation);
      




    }

    // Update is called once per frame
    void Update() {
        frame = frame + 1;
        Vector2 currentPos = transform.position;
        speed2 = myRigidbody.velocity.magnitude;

       // Debug.Log(speed2);
        if (speed2 < 0.5 && theGameManager.isDead == false)
        {
            theGameManager.restartGame();


        }


        //grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
        grounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if (transform.position.x > milestoneCount)
        {

            milestoneCount += milestone;
            speed = speed * speedMulti;
            milestone += milestone * speedMulti;
        }
        myRigidbody.velocity = new Vector2(speed, myRigidbody.velocity.y);
        
        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        isduck = duckManager.duck;
		//Debug.Log(duckManager.duck);
		myAnimator.SetBool("Duck", duckManager.duck);

        if (grounded == true)
        {

            doubleJump = true;

        }
        lastPos = transform.position;




    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "killbox") 
      {
      //Debug.Log("testing");
       theGameManager.restartGame();

      }
    }


}


