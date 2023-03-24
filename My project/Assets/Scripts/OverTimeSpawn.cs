using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverTimeSpawn : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public Transform SpawnPosition;
    public float TimeBetweenSpawns = 60.0f;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
        yield return new WaitForSeconds(TimeBetweenSpawns);
        Instantiate(ObjectToSpawn, SpawnPosition.position, SpawnPosition.rotation);
        }
    }
}
