using UnityEngine;
using System.Collections;

public class Field : MonoBehaviour {

	public int charge = 10 ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		Ennemy ennemy = other.gameObject.GetComponent<Ennemy>();

		if (ennemy != null) {
			GameObject.Destroy( ennemy.gameObject ) ;
			if(--charge <=0)
				GameObject.Destroy(gameObject);
		}
	}
}
