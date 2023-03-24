using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public int damage = 10;


    void Start()
    {
        rb.velocity = transform.forward * speed;
    }
    
    void OnTriggerEnter(Collider DamnEnemy)
    {
        Enemy enemy = DamnEnemy.GetComponent<Enemy>();
        ProjectileWeapon player = gameObject.GetComponent<ProjectileWeapon>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy (gameObject);
        }
        if (player != null)
        {
            player.CollectArrow();
            Destroy(gameObject);
        }
    }
}
