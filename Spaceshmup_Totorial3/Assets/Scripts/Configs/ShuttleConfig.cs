using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shuttle Config")]
public class ShuttleConfig : BaseConfig
{
    [field: SerializeField] public Sprite icon {get; private set;}
   [field: SerializeField] public EShuttleType shuttleType {get; private set;}
   [field: SerializeField] public EBulletType eBulletType {get; private set;}
    [field : SerializeField] public float shuttleSpeed {get; private set;} = 14;
    [field : SerializeField] public float timeInterval{get; private set;}  = .5f;
}
