using UnityEngine;
using System.Collections;

public class Bomb : BellBehaviour {

    public float radius ;

    void OnTriggerEnter(Collider other)
    {
        Ennemy ennemy = other.gameObject.GetComponent<Ennemy>();

        if(ennemy != null)
        {
			action();            
        }
    }

	public override void action(){

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

	public override void onZero(){

	}
}