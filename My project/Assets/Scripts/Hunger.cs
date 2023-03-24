using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;   

public class Hunger : MonoBehaviour
{
    public float CurrentHunger = 100f;
    public float MaxHunger = 100f;
    
    public AudioSource EatSound;
    public Text ValueText;
    
    void Start()
    {
            StartCoroutine(OverTimeHunger());
    }

    void Update()
    {
        if(CurrentHunger > 100)
        {
            CurrentHunger = 100;
        }
        
        if(CurrentHunger < 0)
        {
            gameObject.GetComponent<PlayerHealthScript>(). Die();
        }
        ValueText.text = CurrentHunger.ToString();
    }
    
    
    public void EatFood(float HungerToStill)
    {
        EatSound.Play();
        CurrentHunger += HungerToStill;
    }

    IEnumerator OverTimeHunger()
    {
        while (true)
        {
        yield return new WaitForSeconds(30f);
        CurrentHunger--;
        }
    }

}
