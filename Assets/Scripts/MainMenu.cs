using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        //Debug.Log("yes");
		if (this.gameObject.name == "Back") {
			
			SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);

		}
		if (this.gameObject.name == "playButton") {

			SceneManager.LoadScene("Endless", LoadSceneMode.Single);

		}

    }
}
