using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _roads;
    [SerializeField] private float _roadLength = 40f;
    private GameObject _road;
   

    private void Start()
    {
        _road = Instantiate(_roads[UnityEngine.Random.Range(0, _roads.Count - 1)], transform.position,
            Quaternion.identity);
    }

    public void Spawn()
    {
        Vector3 position = new Vector3(0, 0, _road.transform.position.z + _roadLength);
        _road = Instantiate(_roads[UnityEngine.Random.Range(0, _roads.Count - 1)], position,
            Quaternion.identity);
    }
    
}
