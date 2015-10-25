﻿using UnityEngine;
using System.Collections;

public class Canon : MonoBehaviour {

    LineRenderer lineRenderer;

	// Use this for initialization
	void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            fire();            
        }

    }

    void fire()
    {
        RaycastHit objectHit;
        //Vector3 fwd = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position, transform.forward * 1000, Color.green);
        if (Physics.Raycast(transform.position, transform.forward, out objectHit))
        {
            lineRenderer.SetVertexCount(2);
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, objectHit.point);
            objectHit.transform.gameObject.GetComponent<Ennemy>().Die();
        }
        else
        {
            lineRenderer.SetVertexCount(2);
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.position + 800 * transform.forward);
        }
        lineRenderer.enabled = true;

        Invoke("hide",0.15f);
    }

    void hide()
    {
        lineRenderer.enabled = false;
    }
}