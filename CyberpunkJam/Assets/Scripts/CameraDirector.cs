﻿using UnityEngine;
using System.Collections;

public class CameraDirector : MonoBehaviour {

    public float yOffset = 1.3F;

	// Use this for initialization
	void Start () {
        if (GameObject.FindGameObjectsWithTag("Player") != null)
        {
            var playerObject = GameObject.FindGameObjectWithTag("Player");
            transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + yOffset, transform.position.z);
        }
	}
	
	// Update is called once per frame
	void Update () {
        var playerObject = GameObject.FindGameObjectWithTag("Player");

        if (GameObject.FindGameObjectWithTag("Player") != null)
            transform.position = new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + yOffset, transform.position.z);

        if (transform.position.y <= 0)
            transform.position = new Vector3(playerObject.transform.position.x, 0, transform.position.z);
	}
}
