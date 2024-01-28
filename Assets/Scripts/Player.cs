using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private RoadSpawner roadSpawner;

    private void OnTriggerEnter(Collider other)
    {
        roadSpawner.Spawn();
    }
}
