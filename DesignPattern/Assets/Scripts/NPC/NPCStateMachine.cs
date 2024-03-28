using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCStateMachine : StateMachine
{
    public IdleState idleState;
    public JumpState jumpState;

    private Rigidbody characterController ;
    public NPCStateMachine(Rigidbody characterController )
    {
        this.characterController = characterController;
        CreateState();
    }

    public override void CreateState()
    {
        idleState = new IdleState();
        jumpState = new(characterController);
    }

    
}
