using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {

    public Collider2D bullet;
    public float bulletTimeToLive = 2f;
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
        Collider2D bulletClone = (Collider2D)Instantiate(bullet, transform.position, transform.rotation);
        if (transform.localScale.x < 0)
        {
            bulletClone.GetComponent<BulletCollider>().moveSpeed *= -1;
        }
        Destroy(bulletClone, bulletTimeToLive);
        bulletClone.GetComponent<BulletCollider>().firedByEnemy = false;
    }
}
