using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {

    public Rigidbody2D bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("left shift"))
        {
            Fire();
        }
	}

    void Fire()
    {
        Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.GetComponent<BulletCollider>().moveSpeed *= transform.localScale.x;
    }
}
