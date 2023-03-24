using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealEnemyDamageOnCollision : MonoBehaviour
{
    public int DamageToDeal = 50;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider EnemyHurt)
    {
        if(EnemyHurt.gameObject.tag == "Enemy")
        {
            EnemyHurt.GetComponent<Enemy>(). TakeDamage(DamageToDeal);
        }
    }
}
