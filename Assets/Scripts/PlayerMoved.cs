using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    


public class PlayerMoved : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    #if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            Vector2 positionOnScreen = myTouch.position;
            Debug.Log(positionOnScreen);
            
        }
    #endif
    }
}
