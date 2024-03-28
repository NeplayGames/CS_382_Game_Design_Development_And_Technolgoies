using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instanceGameManager;
    
    void Awake(){
        if(_instanceGameManager == null)
            _instanceGameManager = this;
        else
            Destroy(this.gameObject);
    }
    
    public void PrintMessage(){
        print("This is a message");
    }
}
