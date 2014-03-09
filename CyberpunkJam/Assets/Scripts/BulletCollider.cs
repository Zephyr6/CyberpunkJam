using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour
{

    //public Vector2 moveSpeedVector = new Vector2();
    public float moveSpeed = 1f;
    public int damage = 1;
    public bool firedByEnemy = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + moveSpeed,
            transform.position.y, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (firedByEnemy && other.tag == "Player")
        {
            DestroyObject(this.gameObject);
        }
        else if (!firedByEnemy && other.tag == "Enemy")
        {
            DestroyObject(this.gameObject);
        }
    }
}