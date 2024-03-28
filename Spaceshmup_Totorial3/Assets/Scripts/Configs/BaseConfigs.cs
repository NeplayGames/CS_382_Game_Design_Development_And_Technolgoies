using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class BaseConfig : ScriptableObject
{
   [field: SerializeField] public GameObject prefab {private set; get;}

   protected virtual void OnValidate(){
      Assert.IsNotNull(prefab, $"{nameof(prefab)} cannot be null in {name}");
   }
}

