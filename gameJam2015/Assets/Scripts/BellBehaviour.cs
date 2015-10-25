using UnityEngine;
using System.Collections;

public  abstract class BellBehaviour : MonoBehaviour {

	public float period ;
	public int loop ;

	private float pTime ;
    private float cLoop ;



	// Use this for initialization
	void Start () {
        reset();
	}
	
	// Update is called once per frame
	void Update () {
		float cTime = Time.time;
		if (cTime - pTime >= period && cLoop != 0) {

            cLoop-- ;
			if(cLoop < 0)
                cLoop = -1 ;
			action ();
			pTime = cTime ;
            
		}
	}

    public void reset()
    {
        pTime = Time.time;
        cLoop = loop;
    }

	public abstract void action () ;
    public abstract void onZero() ;
}
