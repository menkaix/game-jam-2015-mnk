using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public GameObject menu ; 

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.GetComponent<Ennemy> () == null)
			return;
		Spawner.ok = false;
		Ennemy [] ens  = GameObject.FindObjectsOfType<Ennemy> ();
		foreach (Ennemy en in ens) {
			GameObject.Destroy(en.gameObject);
		}

		menu.SetActive (true);
	}
}
