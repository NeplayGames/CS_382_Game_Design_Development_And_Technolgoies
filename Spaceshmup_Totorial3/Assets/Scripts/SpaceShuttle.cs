using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class SpaceShuttle : MonoBehaviour
{
    public ShuttleConfig shuttleConfig{private get; set;}
    public Factory factory{private get; set;}
    private float tempTime = 0;

    // Update is called once per frame
    void Update()
    {
        InstantiateBullet();
        MovementControl();
    }

    private void MovementControl()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var speedPerFrame = Time.deltaTime * shuttleConfig.shuttleSpeed;
        transform.position += Vector3.right * horizontal * speedPerFrame + Vector3.up * vertical * speedPerFrame;
    }

    private void InstantiateBullet()
    {
        tempTime += Time.deltaTime;
        if(tempTime > shuttleConfig.timeInterval){
            factory.GetBullet(shuttleConfig.eBulletType, transform.position, transform.rotation);
            tempTime = 0;
        }
    }
}
