using UnityEngine;
using System.Collections;

public class Perso : MonoBehaviour {
	public float speed=50f;
	private float speedH=0.5f;
	public GameObject right;
	public float ball_sp=80000f;
	private static int iter=0;
	public GameObject [] balles;
	public float follow_speed=1f;
	public GameObject camsTarget;
	
	
	//items
	public GameObject bombModel;
	public GameObject wardModel;
	public GameObject barrierModel;
	
	public static int items=0;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit [] hits = Physics.RaycastAll(ray);
		foreach(RaycastHit hit in hits)
        {
            if (hit.transform.gameObject.layer == 8)
            {
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
                break ;
            }
		}

        //transform.position = new Vector3 (transform.position.x + speed * Input.GetAxis ("Horizontal"), transform.position.y, transform.position.z + speed * Input.GetAxis ("Vertical"));
		
		
		
		if(Input.GetKeyDown("u")){
			items=0;
		}
		if(Input.GetKeyDown("i")){
			items=1;
		}
		if(Input.GetKeyDown("o")){
			items=2;
		}
		
		
		
		if (Input.GetMouseButtonDown (1)) {
			switch(items){
			case 0:
				//Debug.Log("instanciating bombe...");
				GameObject bomb = GameObject.Instantiate(bombModel, bombModel.transform.position, bombModel.transform.rotation) as GameObject;
				bomb.SetActive(true);
				bomb.transform.parent=null;
				break;
			case 1:
                    //Debug.Log("instanciating bouclie...");
                GameObject ward =GameObject.Instantiate(wardModel, wardModel.transform.position, wardModel.transform.rotation) as GameObject;
                ward.SetActive(true);
				ward.transform.parent=null;
				break;
			case 2:	
				//Debug.Log("instanciating bombe...");
				GameObject barrier = GameObject.Instantiate(barrierModel, barrierModel.transform.position, barrierModel.transform.rotation) as GameObject;
				barrier.SetActive(true);
				barrier.transform.parent=null;
				break;
			}
			
		}
		
	}
}
