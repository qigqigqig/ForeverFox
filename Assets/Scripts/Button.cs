using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Button : MonoBehaviour {
	public Animator anim;
	public UnityEngine.UI.Button Button1;
	public UnityEngine.UI.Button Button2;
	public GameObject[] pauseObjects;
	public GameObject pauseText;
	public GameObject menuButton;

	// Use this for initialization
	void Start () {
		Scene scene = SceneManager.GetActiveScene ();
		//Debug.Log (scene.name);
		anim = GetComponent<Animator>();
		Time.timeScale = 1;
		pauseObjects = GameObject.FindGameObjectsWithTag("paused");
		if (scene.name == "Endless") {
			pauseText.SetActive (false);
			menuButton.SetActive (false);
		}
			//hidePaused();
		//anim.Stop();	
		//UnityEngine.UI.Button myButton;
		//myButton = myButton.GetComponent<Button> ();
		Button1.onClick.AddListener(TaskOnClick);
	//	Button2.onClick.AddListener(pauseControl);

//		Button2.onClick.AddListener(TaskOnClick);
		//pauseControl();

	}
	
	// Update is called once per frame
	void Update () {

	//	Debug.Log (Time.timeScale);

	}

	void TaskOnClick()
	{
		//Output this to console when the Button is clicked
		//Debug.Log("You have clicked the button!");
		//Debug.Log (this.gameObject.name);
		if (this.gameObject.name == "playButton" || this.gameObject.name == "retryButton") {
			
			SceneManager.LoadScene ("Endless", LoadSceneMode.Single);
		}
		if (this.gameObject.name == "creditsButton") {

			SceneManager.LoadScene ("Credits", LoadSceneMode.Single);
		}
		if (this.gameObject.name == "menuButton") {

			SceneManager.LoadScene ("TitleScreen", LoadSceneMode.Single);
		}
		if (this.gameObject.name == "tutorialButton") {

			SceneManager.LoadScene ("Tutorial", LoadSceneMode.Single);
		}
		if (this.gameObject.name == "pauseButton") {
			pauseControl ();
		}
	}



	//controls the pausing of the scene
	 void pauseControl(){
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			pauseText.SetActive (true);
			menuButton.SetActive (true);
		} else if (Time.timeScale == 0){
			Time.timeScale = 1;
			pauseText.SetActive (false);
			menuButton.SetActive (false);
		}
	}

	//shows objects with ShowOnPause tag
	public void showPaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(true);
		}
	}

	//hides objects with ShowOnPause tag
	public void hidePaused(){
		foreach(GameObject g in pauseObjects){
			g.SetActive(false);
		}
	}



	}

