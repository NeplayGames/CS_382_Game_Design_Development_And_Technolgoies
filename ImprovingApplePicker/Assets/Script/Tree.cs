using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float distance= 5f;

    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = initialPosition.x * Vector3.right + DetermineTreePosition();
    }

    private Vector3 DetermineTreePosition()
    {
        //The range will be -.5f to .5f
       float xPosition = (Mathf.PingPong(Time.timeSinceLevelLoad * speed,1) -.5f) * distance;
       return new(xPosition, transform.position.y, transform.position.z);
    }
}
