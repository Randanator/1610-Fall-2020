using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public GameObject zombie;
    private float range = 24f;
    private float spawnDelay = 5f;
    private Vector3 spawnArea;
    private void Update()
    {
        spawnArea = new Vector3(Random.Range(-range, range), 0, Random.Range(-range, range));
        spawnDelay -= 1 * Time.deltaTime;
        if (spawnDelay <= 0)
        {
            Instantiate(zombie, spawnArea, Quaternion.identity);
            spawnDelay = 5f;
        }
        
    }
}
