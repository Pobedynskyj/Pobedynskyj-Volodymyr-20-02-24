using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    
    [SerializeField] private RoadSpawner roadSpawner;


    private void FixedUpdate()
    {
        /*if(Input.GetMouseButton(0))
        {
            PlayerMove();
        }*/
    }

    private void PlayerMove()
    {
        /*float halfScreen = Screen.width / 2;
        float xPos = (Input.mousePosition.x - halfScreen) / halfScreen;

        playerTransform.localPosition = new Vector3(xPos, 1, 0);*/
    }
    
    
    private void OnTriggerEnter(Collider other)
    {
        roadSpawner.Spawn();
    }
}
