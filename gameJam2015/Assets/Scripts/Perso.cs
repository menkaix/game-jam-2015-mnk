using UnityEngine;
using System.Collections;

public class Perso : MonoBehaviour {
	private float speed=0.05f;
	private float speedH=0.5f;
	public GameObject right;
	public float ball_sp=80000f;
	private static int iter=0;
	public GameObject [] balles;
	public float follow_speed=1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 0f;
		
		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;
		
		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0,-angle,0));

		if (Input.GetKey("z")) {
			cams.transform.position += GameObject.Find("Cams") * follow_speed;
			Vector3 next=new Vector3(Input.mousePosition.x,0,Input.mousePosition.z);
			transform.Translate(next* Time.deltaTime*speed);
		}

		if (Input.GetKey("q")) {
			Vector3 next=new Vector3(right.transform.localPosition.x,0,right.transform.localPosition.z);
			transform.Translate(next* Time.deltaTime*speedH);
		}

		if (Input.GetKey("d")) {
			Vector3 next=new Vector3(right.transform.localPosition.x,0,right.transform.localPosition.z);
			transform.Translate(-next* Time.deltaTime*speedH);
		}

		if (Input.GetKey("s")) {
			Vector3 next=new Vector3(Input.mousePosition.x,0,Input.mousePosition.z);
			transform.Translate(-next* Time.deltaTime*speed);
		}

		if (Input.GetMouseButtonDown (0)) {
			if(iter>9){
				iter=0;
			}
			Vector3 mousep=Input.mousePosition;
			mousep.z= Vector3.Distance(Camera.main.transform.position, transform	.position);;
			Vector3 direction = (Camera.main.ScreenToWorldPoint(mousep)-balles[iter].transform.position).normalized;
			balles[iter].transform.parent=null;
			balles[iter].GetComponent<SphereCollider> ().isTrigger = false;
			balles[iter].GetComponent<Rigidbody>().AddForce(direction*ball_sp);
			iter++;
		}
	}
}
