using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeapon : MonoBehaviour
{
    public GameObject Projectile;
    public Transform FirePoint;
    public float TimeToFire;
    public Animator animator;
    public bool Fireable = true;
    public int RemainingArrows, MaxArrows =  10;
    

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && Fireable == true && RemainingArrows > 0)
        {
            Fireable = false;
            StartCoroutine(FireTimer());
        }
    }


    IEnumerator FireTimer()
    {
        RemainingArrows--;
        animator.SetTrigger("Spanning");
        yield return new WaitForSeconds(TimeToFire);
        Fireable = true;
        Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
    }

    public void CollectArrow()
    {
        RemainingArrows++;
    }
}
