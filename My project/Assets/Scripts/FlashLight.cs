using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    public GameObject Flashlight;
    public AudioSource OnSound;
    public bool on;
    public bool off;

    void Start()
    {
        off = true;
    }

    void Update()
    {
        if(off && Input.GetKeyDown(KeyCode.F))
        {
            Flashlight.SetActive(true);
            OnSound.Play();
            off = false;
            on = true;
        }
        else if(on && Input.GetKeyDown(KeyCode.F))
        {
            Flashlight.SetActive(false);
            OnSound.Play();
            off = true;
            on = false;
        }
    }
}
