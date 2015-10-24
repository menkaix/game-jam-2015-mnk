using UnityEngine;
using System.Collections;

public class AutoMove : MonoBehaviour {

	public float speed ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + speed * transform.forward;
	}
}
