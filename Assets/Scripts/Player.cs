using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private RoadSpawner roadSpawner;
    [SerializeField] private Joystick _joystick;


    private void FixedUpdate()
    {
        PlayerMove(_joystick.Direction.x);
    }

    private void PlayerMove(float posX)
    {
        playerTransform.localPosition = new Vector3(posX * 2, playerTransform.localPosition.y, playerTransform.localPosition.z);
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        roadSpawner.Spawn();
    }
}
