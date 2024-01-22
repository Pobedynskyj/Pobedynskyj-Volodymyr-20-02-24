using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMovement : MonoBehaviour
{
    
    [SerializeField] private float speed = 100f;
    private Vector3 _startPosition;

    void Start()
    {
        _startPosition = transform.position;
    }

    
    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
        
        
    }
}
 
