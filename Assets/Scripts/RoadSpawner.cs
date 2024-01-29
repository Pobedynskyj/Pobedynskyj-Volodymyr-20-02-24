using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> roads;
    [SerializeField] private float roadLength = 40f;
    private GameObject _road;
   

    private void Start()
    {
        _road = Instantiate(roads[UnityEngine.Random.Range(0, roads.Count - 1)], transform.position,
            Quaternion.identity);
    }

    public void Spawn()
    {
        Vector3 position = new Vector3(0, 0, _road.transform.position.z + roadLength);
        _road = Instantiate(roads[UnityEngine.Random.Range(0, roads.Count - 1)], position,
            Quaternion.identity);
    }
    
}
