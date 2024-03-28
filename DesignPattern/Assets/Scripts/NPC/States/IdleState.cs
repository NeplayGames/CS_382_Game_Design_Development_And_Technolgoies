using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    public void Enter()
    {
        InputManager.direction += ChangeDirection;
        
    }
 private void ChangeDirection(float arg1, float arg2)
    {
        Debug.Log($"The values are {arg1} and {arg2}");
    }
    public void Exit()
    {
        InputManager.direction -= ChangeDirection;
    }

    public void Update()
    {
    }
}
