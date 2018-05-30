using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject[] platforms;
    public float spawnMin = 1f;
    public float spawnMax = 2f;
	public spawnManager spawners; 
	public int canSpawn = 0;

	void Start () {
        Spawn();
	}
	
	void Update () {

	
	}

    void Spawn()
    {
		if (canSpawn == 1) {
			Instantiate (platforms [Random.Range (0, platforms.Length)], transform.position, Quaternion.identity);
			Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
		}
		}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "spawnon") {
			Debug.Log ("TURN SPAWNER ON");
			if (canSpawn == 0) {
				canSpawn = 1;
				Spawn ();
			}
			canSpawn = 1;

			}
		if (other.gameObject.name == "spawnoff") {
			Debug.Log ("TURN SPAWNER OFF");
			canSpawn = 0;
		}
	}
}
