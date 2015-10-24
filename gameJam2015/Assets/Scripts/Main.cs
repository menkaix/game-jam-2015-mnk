using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public Camera cams;
	public GameObject character;
	public static Vector3 offset;
	public float follow_speed;
	// Use this for initialization
	void Start () {
		offset = cams.transform.position-character.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
