using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public BulletConfig bulletConfig{get; set;}
    // Update is called once per frame
    void Update()
    {
         transform.position += Vector3.up * bulletConfig.speed * Time.deltaTime;
    }

    void OnValidate(){
    }
}
