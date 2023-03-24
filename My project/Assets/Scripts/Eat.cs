using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public float HungerToStill = 20f;
    public GameObject Particles;
    public Transform par;
    public GameObject CookedFood;
    public bool IsCooked;
    public float CookTime = 5.0f;

    
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider EatColl)
    {

        if(EatColl.gameObject.tag == "Player")
        {
            Debug.Log("Omnomnom");
            Instantiate(Particles, par.position, par.rotation);
            EatColl.GetComponent<Hunger> ().EatFood(HungerToStill);
            Destroy(gameObject);
        }
        if(EatColl.gameObject.tag == "Fire" && IsCooked == false)
        {
            IsCooked = true;
            StartCoroutine(CookingFood());
        }
    }

    IEnumerator CookingFood()
    {
        yield return new WaitForSeconds(CookTime);
        Instantiate(CookedFood, par.position, par.rotation);
        Destroy(gameObject);
    }
}
