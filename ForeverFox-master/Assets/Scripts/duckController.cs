using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duckController : MonoBehaviour
{
    public bool duck = false;

    public AudioClip duckSound;
    private AudioSource source;
	public UnityEngine.UI.Button Button1;


    // Use this for initialization
    void Start()
    {
		Button1.onClick.AddListener(OnMouseDown);

    }
    void Awake()
    {

        source = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButton(0))
            duck = true;
        else
            duck = false;*/

	//	Debug.Log (duck);

    }

    void OnMouseDown()
    {
        if (duck == false)
        {
            source.PlayOneShot(duckSound, 1);

            StartCoroutine(Wait());
        }

    }
    IEnumerator Wait()
    {
		//Debug.Log (duck);
        duck = true;
		//Debug.Log (duck);
            yield return new WaitForSeconds(1.0f);
        duck = false;
		//Debug.Log (duck);
     //   Debug.Log("Hi");

        

    }
}