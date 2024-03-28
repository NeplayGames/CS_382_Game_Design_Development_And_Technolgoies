using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    [SerializeField] private Rigidbody characterController;
    private NPCStateMachine nPCStateMachine;
    // Start is called before the first frame update
    void Start()
    {
        nPCStateMachine = new(characterController);
        nPCStateMachine.ChangeState(nPCStateMachine.idleState);
    }

   

    // Update is called once per frame
    void Update()
    {
        nPCStateMachine.Update();
        InputManager.Update();
        if(Input.GetMouseButtonDown(0)){
            nPCStateMachine.ChangeState(nPCStateMachine.jumpState);
        }else{
            nPCStateMachine.ChangeState(nPCStateMachine.idleState);

        }
    }

    void OnDestroy(){
    }
}
