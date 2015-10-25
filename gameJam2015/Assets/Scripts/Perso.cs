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
	private static Vector3 track_offset;
	
	//items
	public GameObject bombe;
	public GameObject bouclie;
	public GameObject barriere;
	
	public static int items=0;
	
	// Use this for initialization
	void Start () {
		track_offset=camsTarget.transform.position-transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit)) {
			//Debug.DrawLine(ray.origin, hit.point);
			
			//gameObject.transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
			//Vector3 targetLookAt = hit.point - transform.position ;
			
			transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
		}
		transform.position = new Vector3 (transform.position.x + speed * Input.GetAxis ("Horizontal"), transform.position.y, transform.position.z + speed * Input.GetAxis ("Vertical"));
		
		if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
			camsTarget.transform.position = transform.position+track_offset;
		}
		
		if(Input.GetKeyDown("u")){
			items=0;
		}
		if(Input.GetKeyDown("i")){
			items=1;
		}
		if(Input.GetKeyDown("o")){
			items=2;
		}
		
		if (Input.GetMouseButtonDown (0)) {
			//if(iter>9){
			//	iter=0;
			//}
			Vector3 mousep=Input.mousePosition;
			mousep.z= Vector3.Distance(Camera.main.transform.position, transform.position);;
			Vector3 direction = Camera.main.ScreenToWorldPoint(mousep);
			//balles[iter].transform.parent=null;
			//balles[iter].GetComponent<SphereCollider> ().isTrigger = false;
			//balles[iter].GetComponent<Rigidbody>().AddForce(direction*ball_sp);
			//iter++;
			RaycastHit objectHit;
			Vector3 fwd = transform.TransformDirection(Vector3.forward);
			//Debug.DrawRay(transform.position, fwd * 100, Color.green);
			if (Physics.Raycast(transform.position, fwd, out objectHit, 100))
			{
				//do something if hit object ie
				//if(objectHit.name=="Enemy"){
				Debug.Log("enemis: "+objectHit.transform.gameObject.name);
				//}
			}
		}
		
		if (Input.GetMouseButtonDown (1)) {
			switch(items){
			case 0:
				//Debug.Log("instanciating bombe...");
				Vector3 pos=new Vector3(bombe.transform.position.x,bombe.transform.position.y,bombe.transform.position.z);
				GameObject bomb =(GameObject)Instantiate(bombe, pos, Quaternion.identity);
				bomb.SetActive(true);
				bomb.GetComponent<MeshRenderer>().enabled=true;
				bomb.transform.parent=null;
				break;
			case 1:	
				//Debug.Log("instanciating bouclie...");
				GameObject boucl =(GameObject)Instantiate(bouclie, bouclie.transform.position, bouclie.transform.rotation);
				bouclie.SetActive(true);
				boucl.GetComponent<MeshRenderer>().enabled=true;
				boucl.transform.parent=null;
				break;
			case 2:	
				//Debug.Log("instanciating bombe...");
				GameObject barrier =(GameObject)Instantiate(barriere, barriere.transform.position, barriere.transform.rotation);
				barrier.SetActive(true);
				barrier.GetComponent<MeshRenderer>().enabled=true;
				barrier.transform.parent=null;
				break;
			}
			
		}
		
	}
}
