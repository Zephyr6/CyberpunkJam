using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour {

    public int Health;
    public bool IsDead = false;
    public int MaxHealth = 100;
	// Use this for initialization
	void Start () {
        Health = MaxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (Health <= 0)
        {
            IsDead = true;
        }
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Projectile")
        {
            if (other.GetComponent<BulletCollider>().firedByEnemy)
            {
                Health -= other.GetComponent<BulletCollider>().damage;
            }
        }
    }
}
