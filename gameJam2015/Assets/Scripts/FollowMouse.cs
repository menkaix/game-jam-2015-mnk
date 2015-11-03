using UnityEngine;
using System.Collections;

public class FollowMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit)) {
			//gameObject.transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
			//Vector3 targetLookAt = hit.point - transform.position ;

			transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
		}

	}
}
