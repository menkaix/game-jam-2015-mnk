using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

    public float radius ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        Ennemy ennemy = other.gameObject.GetComponent<Ennemy>();

        if(ennemy != null)
        {
            GameObject.Destroy(ennemy.gameObject);
            RaycastHit[] hits = Physics.SphereCastAll(transform.position, radius, transform.forward,0);

            foreach(RaycastHit hit in hits)
            {
                Ennemy enn = hit.transform.gameObject.GetComponent<Ennemy>();
                if(enn != null)
                {
                    GameObject.Destroy(enn.gameObject);
                }

            }
            GameObject.Destroy(gameObject);
        }
    }
}
