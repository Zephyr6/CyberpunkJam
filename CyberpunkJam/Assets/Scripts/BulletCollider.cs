using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour
{

    public Vector2 moveSpeedVector = new Vector2();
    public float moveSpeed = 1f;
    public int damage = 1;
    public float timeToLive = 2f;
    public bool firedByEnemy = false;
    private float timer = 0;
    // Use this for initialization
    void Start()
    {
        timer = timeToLive;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            DestroyObject(this.gameObject);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + moveSpeedVector.x,
            transform.position.y + moveSpeedVector.y, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (firedByEnemy && other.tag != "Enemy")
        {
            DestroyObject(this.gameObject);
        }
        else if (!firedByEnemy && other.tag != "Player")
        {
            DestroyObject(this.gameObject);
        }
    }
}