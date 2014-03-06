using UnityEngine;
using System.Collections;

public class TurretGun : MonoBehaviour {

    public Rigidbody2D bullet;
    public float timeToShoot = 2.0f;
    public float aggroRadius = 10f;
    private float timer = 0;
    // Use this for initialization
    void Start()
    {
        timer = timeToShoot;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (timer <= 0)
        {
            var player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                float distanceToPlayer = Vector2.Distance(transform.position, player.transform.position);
                if (distanceToPlayer <= aggroRadius)
                {
                    Fire(player.transform.position);
                }
            }
            timer = timeToShoot;
        }
        else
        {
            timer -= Time.deltaTime;
        }

    }

    void Fire(Vector2 target)
    {
        Rigidbody2D bulletClone = (Rigidbody2D)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = (GameObject.Find("Player").transform.position - transform.position).normalized * bulletClone.GetComponent<BulletCollider>().moveSpeed;
        bulletClone.GetComponent<BulletCollider>().firedByEnemy = true;
    }
}
