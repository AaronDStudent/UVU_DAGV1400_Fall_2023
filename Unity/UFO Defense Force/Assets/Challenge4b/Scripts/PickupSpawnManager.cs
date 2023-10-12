using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class PickupSpawnManager : MonoBehaviour
{
    public GameObject[] pickupPrefabs;
    
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;
    
    private float startDelay = 10.0f;
    private float spawnInterval = 10.0f;
    
    void Start()
    {
        InvokeRepeating("SpawnPickup", startDelay, spawnInterval);
    }

    void SpawnPickup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int pickupIndex = Random.Range(0,pickupPrefabs.Length);
        Instantiate(pickupPrefabs[pickupIndex], spawnPos, pickupPrefabs[pickupIndex].transform.rotation);
    }
}