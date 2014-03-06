using UnityEngine;
using System.Collections;

public class BulletCollider : MonoBehaviour
{

    //public Vector2 moveSpeedVector = new Vector2();
    public float moveSpeed = 1f;
    public int damage = 1;
    public float timeToLive = 2f;
    public bool firedByEnemy = false;
    // Use this for initialization
    void Start()
    {
        var colliders = gameObject.GetComponents<Collider2D>();
        foreach (var collider in colliders)
        {
            if (!firedByEnemy)
            {
                var enemies = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (var enemy in enemies)
                {
                    
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, timeToLive);
    }

    void FixedUpdate()
    {
        //transform.position = new Vector3(transform.position.x + moveSpeedVector.x,
        //    transform.position.y + moveSpeedVector.y, transform.position.z);
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