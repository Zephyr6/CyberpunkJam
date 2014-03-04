using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {

    public Collider2D bullet;

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
        int direction = (int)Input.GetAxis("Vertical");
        Collider2D bulletClone = (Collider2D)Instantiate(bullet, transform.position, transform.rotation);
        switch (direction)
        {
            case 0:
                if(transform.localScale.x > 0)
                    bulletClone.GetComponent<BulletCollider>().moveSpeedVector.x = bulletClone.GetComponent<BulletCollider>().moveSpeed;
                else
                    bulletClone.GetComponent<BulletCollider>().moveSpeedVector.x = -bulletClone.GetComponent<BulletCollider>().moveSpeed;
                break;
            case 1:
                bulletClone.GetComponent<BulletCollider>().moveSpeedVector.y = bulletClone.GetComponent<BulletCollider>().moveSpeed;
                break;
            case -1:
                bulletClone.GetComponent<BulletCollider>().moveSpeedVector.y = -bulletClone.GetComponent<BulletCollider>().moveSpeed;
                break;
        }        
        bulletClone.GetComponent<BulletCollider>().firedByEnemy = false;
    }
}
