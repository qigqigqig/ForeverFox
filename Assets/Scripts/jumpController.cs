using UnityEngine;
using System.Collections;

public class jumpController : MonoBehaviour
{
    public AudioClip jump;
    private AudioSource source;
    public PlayerControl thePlayer;
	public UnityEngine.UI.Button Button1;


    void Start()
    {
        thePlayer = FindObjectOfType<PlayerControl>();
        thePlayer.doubleJump = true;
		Button1.onClick.AddListener(OnMouseDown);


    }
    void Awake()
    {

        source = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update()
    {
        if (thePlayer.grounded == true)
        {
            thePlayer.doubleJump = true;

        }
       
    }


void OnMouseDown()
    {
		//Debug.Log ("You Jumped!");
       // thePlayer.myRigidbody.velocity = new Vector2(thePlayer.speed, thePlayer.jump);
        if ( thePlayer.grounded == true || thePlayer.doubleJump == true)
        {
          //  if (thePlayer.isduck == false)
           // {
               // Debug.Log("Hi");
                thePlayer.doubleJump = false;
                thePlayer.myRigidbody.velocity = new Vector2(thePlayer.speed, thePlayer.jump);
                source.PlayOneShot(jump, 1);
            //}
        }


    }
}