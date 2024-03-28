using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bullet Config")]
public class BulletConfig : BaseConfig
{
    [field: SerializeField] public EBulletType bulletType {get; private set;}
    [field : SerializeField, Range(5, 10)] public int speed {get; private set;} = 5;
    
}
