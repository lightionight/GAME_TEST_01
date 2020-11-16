using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static Base_PlayerControl;

namespace GAME_TEST_01.Player
{
    //[RequireComponent(typeof(PlayerInput))]
    public class PlayControlV2 : MonoBehaviour, IMainCharacterActions
    {
        private Vector2 m_Move;
        private Vector2 m_lookAround;
        public float moveSpeed = 10;
        public float rotateSpeed = 60;
        Base_PlayerControl playControl;
        public void OnEnable()
        {
            if(playControl == null)
            {
                playControl = new Base_PlayerControl();
                playControl.MainCharacter.SetCallbacks(this);
            }
            playControl.MainCharacter.Enable();
        }
        public void OnDisable()
        {
            playControl.MainCharacter.Disable();
        }
        public void OnMove(InputAction.CallbackContext context)
        {
            m_Move = context.ReadValue<Vector2>();
        }
        public void OnLookAround(InputAction.CallbackContext context)
        {
            m_lookAround = context.ReadValue<Vector2>();
        }
        private void Move(Vector2 direction)
        {
            if (direction.sqrMagnitude < 0.01)
                return;
            var scaleMoveSpeed = moveSpeed * Time.deltaTime;
            var move = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(direction.x, 0, direction.y);
            transform.position += move * scaleMoveSpeed;

        }
        private void LookAround(Vector2 rotate)
        {
            if(rotate.sqrMagnitude < 0.01)
                return;
            var scaledRotateSpeed = rotateSpeed * Time.deltaTime;
            m_lookAround.y += rotate.x * scaledRotateSpeed;
            m_lookAround.x += Mathf.Clamp(m_lookAround.x - rotate.y * scaledRotateSpeed, -89, 89);
            transform.localEulerAngles = m_lookAround;
        }
        
        public void Update()
        {
            LookAround(m_lookAround);
            Move(m_Move);
        }
    }
}