using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Thirst : MonoBehaviour
{
    public float MaxThirst = 100f;
    public AudioSource ThirstSound;
    public float CurrentThirst = 50f;
    public Text ValueText;

    void Start()
    {
                StartCoroutine(OverTimeThirst());
    }

    void Update()
    {
        if(CurrentThirst > 100)
        {
            CurrentThirst = MaxThirst;
        }
        
        if(CurrentThirst == 0)
        {
            gameObject.GetComponent<PlayerHealthScript>(). Die();
        }
        ValueText.text = CurrentThirst.ToString();
    }

    IEnumerator OverTimeThirst()
    {
        while (true)
        {
        yield return new WaitForSeconds(20f);
        CurrentThirst--;
        }
    }

    public void Dehydrate(int ThirstToStill)
    {
        CurrentThirst += ThirstToStill;
        ThirstSound.Play();
    }

}
