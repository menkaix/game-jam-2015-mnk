using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed = 0.25f ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x + Time.deltaTime * speed * Input.GetAxis("Horizontal"), transform.position.y, transform.position.z + Time.deltaTime * speed * Input.GetAxis("Vertical"));
	}
}
