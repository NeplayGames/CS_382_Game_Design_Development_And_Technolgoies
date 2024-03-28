using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager 
{
    public static event Action<float, float> direction;
   public static void Update(){
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0){
            direction?.Invoke(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        }
   }

}
