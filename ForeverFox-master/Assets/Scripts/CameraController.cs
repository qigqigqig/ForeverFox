using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraController : MonoBehaviour {
    public PlayerControl thePlayer;
    private Vector3 lastPos;
    private float distanceToMove;
    private float distanceToMoveY;
    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<PlayerControl>();
        lastPos = thePlayer.transform.position;

    }

    // Update is called once per frame
    void Update () {
        distanceToMove = thePlayer.transform.position.x - lastPos.x;
     //   distanceToMoveY = thePlayer.transform.position.y - lastPos.y;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        lastPos = thePlayer.transform.position;
	}
}
