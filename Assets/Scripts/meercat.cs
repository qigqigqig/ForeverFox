using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meercat : MonoBehaviour {
    private Animator myAnimator;
    public GameObject fox;
    // Use this for initialization
    void Start () {
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
        //Debug.Log(Vector3.Distance(this.transform.position, fox.transform.position));
        if ((Vector3.Distance(this.transform.position, fox.transform.position)) <= 5)
        {
            //Debug.Log("HI");
            myAnimator.SetBool("close", true);



        }
    }
}
