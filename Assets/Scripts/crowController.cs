using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// it's really just the script for all left moving enemies tbh
public class crowController : MonoBehaviour {
    public float speed;
    public Rigidbody2D myRigidbody;
    private Vector3 startPos;
    private int spawnValue;
    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        //startPos = transform.position;
        //spawnValue = Random.Range(-2, 2);
        //startPos.x = startPos.x + spawnValue;
      //  transform.position = startPos;
    }

    // Update is called once per frame
    void Update () {
        //transform.position.x = this.transform.position.x - 5;
        //Debug.Log("Renderer:" + GetComponent<Renderer>().isVisible);
        if (GetComponent<Renderer>().isVisible)
        {
            myRigidbody.velocity = new Vector2(speed, myRigidbody.velocity.y);
            
        }
        if (this.gameObject.tag == "enemyiskill")
        {
         //   Debug.Log("Killlllll");
           // Destroy(this.gameObject);
        }
     
    }
   
}
