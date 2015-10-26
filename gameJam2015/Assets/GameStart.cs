using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	public GameObject menu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Debut(){
		Spawner.ok = true;
		menu.SetActive (false);
	}
}
