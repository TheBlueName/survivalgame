using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drink : MonoBehaviour
{
    public int ThirstToStill = 20;
    public GameObject Particles;
    public Transform par;

        void OnTriggerEnter(Collider EatColl)
    {

        if(EatColl.gameObject.tag == "Player")
        {
            Debug.Log("Slurpslurpslurp");
            Instantiate(Particles, par.position, par.rotation);
            EatColl.GetComponent<Thirst> ().Dehydrate(ThirstToStill);
            Destroy(gameObject);
        }
}
}
