using UnityEngine;
using System.Collections;

public class Tracking : MonoBehaviour {

	public GameObject target ;
	public float followFactor;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 direction = target.transform.position - transform.position;

		transform.position = transform.position + direction * followFactor;

	
	}
}
