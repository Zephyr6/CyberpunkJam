﻿using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour {

    public float moveSpeed = 1f;
    private Vector3 startPosition;
	// Use this for initialization
	void Start () {
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + moveSpeed, 
            transform.position.y, transform.position.z);
    }
}
