using UnityEngine;
using System.Collections;

public class StickTo : MonoBehaviour {

	Vector3 InitialLocalPosition ;
	// Use this for initialization
	void Start () {
		InitialLocalPosition = transform.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = InitialLocalPosition;
	}
}
