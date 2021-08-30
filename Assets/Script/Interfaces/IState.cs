using System.Collections;
using System.Collections.Generic;
using Script.Movement;
using UnityEngine;

public interface IState
{
    void Update();

    bool CanUpdate();

    void OnStateEnter();
    void OnStateExit();
}
