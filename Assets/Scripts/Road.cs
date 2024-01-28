using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private void Update()
    {
        DestroyRoad();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(-transform.forward * speed * Time.fixedDeltaTime);
    }

    private void DestroyRoad()
    {
        if (transform.position.z < -40f)
        {
            Destroy(gameObject);
        }
        else
        {
            return;
        }
    }
    
}
