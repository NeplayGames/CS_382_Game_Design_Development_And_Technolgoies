using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine 
{
    private IState currentState;

    public void ChangeState(IState state){
        if(currentState == state) return;
        currentState?.Exit();
        currentState = state;
        currentState?.Enter();
    }

    public void Update(){
        currentState?.Update();
    }

    public abstract void CreateState();
}
