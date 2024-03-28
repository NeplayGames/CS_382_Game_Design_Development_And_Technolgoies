using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Assertions;

[CreateAssetMenu(fileName = "SHuttle Info", menuName ="DB/Main Database")]
public class Database : ScriptableObject
{
    [SerializeField] public List<BulletConfig> bulletConfigs;
    [SerializeField] public List<ShuttleConfig> shuttleConfigs;
    
}
