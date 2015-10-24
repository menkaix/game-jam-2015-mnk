using UnityEngine;
using System.Collections;

public class CamsFollow : MonoBehaviour {
	public GameObject target ;
	public float followFactor;
	private Vector3 velocity = Vector3.zero;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = Vector3.SmoothDamp(transform.position, target.transform.position, ref velocity, followFactor);
		
		
	}
}
