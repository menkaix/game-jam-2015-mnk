using UnityEngine;
using System.Collections;

public class Balle : MonoBehaviour {
	// Update is called once per frame
	void Update () {
	
	}
	void Start(){
		//Vector3 tmp=GameObject.Find ("character").transform.position;
		//transform.position = new Vector3 (tmp.x, transform.position.y, tmp.z);
	}
	/*void OnTriggerEnter(Collider col){
		if(col.gameObject.name.CompareTo("enemies")==0){
			transform.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			Vector3 tmp=GameObject.Find ("character").transform.position;
			transform.position = new Vector3 (tmp.x, transform.position.y, tmp.z);
		}
	}*/
	void OnCollisionEnter(Collision col){
		if(col.gameObject.name.CompareTo("enemies")==0){
			transform.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			Vector3 tmp=GameObject.Find ("character").transform.position;
			transform.position = new Vector3 (tmp.x, transform.position.y, tmp.z);
			transform.parent=GameObject.Find ("balles").transform;
		}
		transform.GetComponent<SphereCollider> ().isTrigger = true;
	}
}
