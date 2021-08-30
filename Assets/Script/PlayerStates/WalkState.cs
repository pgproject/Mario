using System.Collections;
using System.Collections.Generic;
using Script.Movement;
using UnityEngine;

public class WalkState : IState
{
    private PlayerStateAction m_playerStateAction;

    public WalkState(PlayerStateAction playerStateAction)
    {
        m_playerStateAction = playerStateAction;
    }

    public void Update()
    {
        throw new System.NotImplementedException();
    }

    public bool CanUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void OnStateEnter()
    {
        throw new System.NotImplementedException();
    }

    public void OnStateExit()
    {
        throw new System.NotImplementedException();
    }

    
}
