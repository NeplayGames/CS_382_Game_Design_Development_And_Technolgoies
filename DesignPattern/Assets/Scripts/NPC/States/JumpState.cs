using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class JumpState : IState
{
    private Rigidbody characterController;

    public JumpState(Rigidbody characterController)
    {
        this.characterController = characterController;
    }

    public void Enter()
    {
        characterController.AddForce(Vector3.up * 100);
    }

    public void Exit()
    {
    }

    void IState.Update()
    {
    }
}
