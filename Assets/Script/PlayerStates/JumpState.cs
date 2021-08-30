using Script.Movement;
using UnityEngine;

namespace Movment.PlayerStates
{
    public class JumpState : IState
    {
        private PlayerStateAction m_playerStateAction;

        public JumpState(PlayerStateAction playerStateAction)
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
            m_playerStateAction.Rigidbody.MovePosition(m_playerStateAction.Rigidbody.transform.position + Vector3.up * GeneralStats.Instance.MovementStats.HeightOfJump);
        }

        public void OnStateExit()
        {
            throw new System.NotImplementedException();
        }
    }
}