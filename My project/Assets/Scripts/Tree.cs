using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public int TreeHealth = 100;
    public GameObject HitParticle;
    public GameObject TreeDrop;
    public Transform parPos;
    
    void Start()
    {
        
    }

     public void TakeTreeDamage(int WeaponDamage)
     {
         TreeHealth -= WeaponDamage;
         Instantiate(HitParticle, parPos.position, parPos.rotation);
     }
 
    
    void Update()
    {
        if(TreeHealth < 0)
        {
            Instantiate(TreeDrop, parPos.position, parPos.rotation);
            Destroy(gameObject);
        }
    }
}
