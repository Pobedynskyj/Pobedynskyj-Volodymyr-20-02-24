using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoved : MonoBehaviour
{
    private Vector2 moveDirection = Vector2.zero;
    
    void Update()
    {
    #if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            if(myTouch.phase == TouchPhase.Moved)
            {
                Vector2 positionChange = myTouch.deltaPosition;
                positionChange.x = -positionChange.x;
                moveDirection = positionChange.normalized;
            }
        }
    #endif
        transform.position += (Vector3)moveDirection * -1f * Time.deltaTime;
    }
}
