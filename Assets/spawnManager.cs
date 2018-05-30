using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour {
	public int spawn = 0;
	public GameObject spawner;
	// Use this for initialization
	void Start () {
		spawner = GameObject.Find("FireFlySpawner");
	}
	
	// Update is called once per frame
	void Update () {
		
	}




}
