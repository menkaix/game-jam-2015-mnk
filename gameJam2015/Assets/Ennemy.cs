﻿using UnityEngine;
using System.Collections;

public class Ennemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Die()
    {
        GameObject.Destroy(gameObject);
    }
}
