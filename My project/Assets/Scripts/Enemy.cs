 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class Enemy : MonoBehaviour
 {
     public int EnemyHealth = 50;
     public GameObject HitParticle;
     public Transform parPos;
     public int EnemyDamage = 1;
 
     void Update()
     {
         if (EnemyHealth <= 0)
         {
             EnemyDie();
         }
     }
 
     public void TakeDamage(int WeaponDamage)
     {
         EnemyHealth -= WeaponDamage;
         Instantiate(HitParticle, parPos.position, parPos.rotation);
     }
 
     void EnemyDie()
     {
         Destroy(gameObject);
     }
 
     void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "Player")
         {
             other.GetComponent<PlayerHealthScript>().DealDamage(EnemyDamage);
         }
     }
 }