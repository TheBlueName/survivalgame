using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{
    public GameObject MeleeWeapon;
    public int WeaponDamage = 10;
    public bool CanAttack = true;
    public float AttackCD = 1.0f;
    public bool isAttacking = false;
    public AudioSource HitSound;
    public BoxCollider coll;
    public bool Holstered = false;

    void Start()
    {
        coll.enabled = false;
    }
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(CanAttack)
            {
                SwordAttack();
                Colactive();
                Invoke("Colinactive", 0.1f);
            }
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            Holstered = true;
            Animator anim = MeleeWeapon.GetComponent<Animator>();
            anim.SetBool("Holster", true);
        }
        
        if(Input.GetKeyDown(KeyCode.R) && Holstered == true)
        {
            Holstered = false;
            Animator anim = MeleeWeapon.GetComponent<Animator>();
            anim.SetBool("Holster", false);
        }
    }

    public void SwordAttack()
    {
        isAttacking = true;
        CanAttack = false;
        Animator anim = MeleeWeapon.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(ResetAttackCooldown());
    }

    IEnumerator ResetAttackCooldown()
    {
        coll.enabled = true;
        yield return new WaitForSeconds(AttackCD);
        CanAttack = true;
        isAttacking = false;
    }

    public void OnTriggerEnter(Collider EnemyHurt)
    {
        if(EnemyHurt.gameObject.tag == "Enemy")
        {
            coll.enabled = true;
            HitSound.Play();
            EnemyHurt.GetComponent<Enemy> ().TakeDamage(WeaponDamage);
        }
        else if(EnemyHurt.gameObject.tag == "Tree")
        {
            coll.enabled = true;
            HitSound.Play();
            EnemyHurt.GetComponent<Tree> (). TakeTreeDamage(WeaponDamage);
        }
    }

    void Colactive()
    {
        coll.enabled = true;
    }

    void Colinactive()
    {
        coll.enabled = false;
    }

}
