using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public AudioSource CollisionSound;

    void OnTriggerEnter(Collider SoundColl)
    {
        CollisionSound.Play();
    }
}
