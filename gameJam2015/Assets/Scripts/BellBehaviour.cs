using UnityEngine;
using System.Collections;

public  abstract class BellBehaviour : MonoBehaviour {

	public float period ;
	public int loop ;

	private float pTime ;



	// Use this for initialization
	void Start () {
		pTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float cTime = Time.time;
		if (cTime - pTime >= period && loop !=0) {

				loop-- ;
				if(loop<0)loop = -1 ;
				action ();
				pTime = cTime ;


		}
	}

	public abstract void action ();
}
