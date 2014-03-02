using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour {

    public Rigidbody2D bullet;
    public float timeToShoot = 2.0f;

    private float timer = 0;
    // Use this for initialization
    void Start()
    {
        timer = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            Fire();
            timer = timeToShoot;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void Fire()
    {
        Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.GetComponent<BulletCollider>().moveSpeed *= transform.localScale.x;
    }
}
