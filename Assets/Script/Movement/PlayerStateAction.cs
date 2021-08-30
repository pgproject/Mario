using System;
using Movment.PlayerStates;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Script.Movement
{
    public class PlayerStateAction : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D m_rigidbody;
        public Rigidbody2D Rigidbody => m_rigidbody;
        
        private IState m_state;

        private WalkState m_walkState;
        private JumpState m_jumpState;

        private void Awake()
        {
            m_jumpState = new JumpState(this);
            m_walkState = new WalkState(this);
        }

        public float Speed;
        public float HeigthOfJump;
        public float SpeedInAir;

        private float m_speedHelp;
        private bool m_isGround;
        [SerializeField] private PlayerInput m_inputAction;


        /*private bool m_InteractWithButton
    {
        get
        {
            if (InteractableObject != null)
                return InteractableObject.InteractWithButton();
            
            return false;
        }
        
    }*/
        //public IInteractable InteractableObject { get; set; }
    
        void Start()
        {
            m_speedHelp = Speed;
        }
   
        void Update()
        {
            if(m_inputAction.currentActionMap["MoveLeft"].ReadValue<float>() > 0)
            {
                m_rigidbody.MovePosition(m_rigidbody.transform.position + Vector3.left * Speed);
            }
            if(m_inputAction.currentActionMap["MoveRight"].ReadValue<float>() > 0)
            {
                m_rigidbody.MovePosition(m_rigidbody.transform.position + Vector3.right * Speed);
            }
            if(m_inputAction.currentActionMap["Jump"].triggered && m_isGround)
            {
                m_state = m_jumpState;
                m_state.OnStateEnter();
                
            }
            /*if (m_inputAction.currentActionMap["Interact"].triggered && m_InteractWithButton)
        {
            InteractableObject?.Interact();
        }*/
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.collider.name == "Ground")
            {
                Speed = m_speedHelp;
                m_isGround = true;
            }
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if(other.collider.name == "Ground")
            {
                Speed /= SpeedInAir;
                m_jumpState.OnStateExit();
                m_isGround = false;
            }
        }
        
    }
}
