using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageCaller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager._instanceGameManager.PrintMessage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
