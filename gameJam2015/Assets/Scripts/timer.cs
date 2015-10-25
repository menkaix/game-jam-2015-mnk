using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {
	public float scale=0.5f;
	public Transform target;
	public static int gameState=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameState == 0) {
			float step = scale * Time.deltaTime;
			transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, scale);
		}
		float angle = Quaternion.Angle(transform.rotation, target.rotation);
		bool anglecheck = angle < 0.05f;
		if(anglecheck && gameState==0){
			gameState=1;
			Debug.Log("Games Overs...");
		}
	}
}
