using UnityEngine;
using System.Collections;

public class WayPoint : MonoBehaviour {

	public WayPoint way1 ;
	public WayPoint way2 ;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		if (other.GetComponent<Ennemy> () == null)
			return ;

		float factor = Random.value - Random.value;

		if (factor < 0) {
			if(way1 != null){
				other.gameObject.transform.LookAt(way1.transform.position);
			}
			else
			{
				GameObject.Destroy(other.gameObject);
			}

		} else {
			if(way1 != null)
				other.gameObject.transform.LookAt(way2.transform.position);
			else
				GameObject.Destroy(other.gameObject);
		}
        
	}
}
