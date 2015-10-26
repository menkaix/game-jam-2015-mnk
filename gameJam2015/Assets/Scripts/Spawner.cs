using UnityEngine;
using System.Collections;


public class Spawner : BellBehaviour {

	public GameObject original ;

	public static bool ok = false;

	public override void action(){

		if (!ok)
			return;

		GameObject go = GameObject.Instantiate (original);
		go.transform.parent = transform;
		go.transform.localPosition = new Vector3 (0,0,0);
		go.transform.parent = transform.parent;

		float factor = Random.value - Random.value;
		
		if (factor < 0) {
			go.gameObject.transform.LookAt(GetComponent<WayPoint>().way1.transform.position);
		} else {
			go.gameObject.transform.LookAt(GetComponent<WayPoint>().way2.transform.position);
		}
	}

    public override void onZero()
    {
        
    }

}
