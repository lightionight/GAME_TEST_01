using UnityEngine;
using UnityEngine.InputSystem;
using static Base_PlayerControl;

// https://www.zhihu.com/question/375434426 保持unity方向同摄像机方向一样

namespace GAME_TEST_01.Player
{
    //[RequireComponent(typeof(PlayerInput))]
    public class PlayControlV2 : MonoBehaviour, IMainCharacterActions
    {
        private Base_PlayerControl playControl;
        private Vector2 m_Move;
        private Vector2 m_lookAround;
        private Vector3 targetPos;
        private bool    m_jumpStatu = false;
        private float   m_Jump = 5.0f;
        private float   m_realTimeDistance;

        public float moveSpeed = 10;
        public float rotateSpeed = 50;
        public GameObject mainCamera;

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
        public void OnJump(InputAction.CallbackContext context)
        {
            if(context.action.triggered)
            {
                m_jumpStatu = true;
            }

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
            float rotAngle, rollAngle;
            if (rotate.sqrMagnitude < 0.1)
                return;
            var scaledRotateSpeed = rotateSpeed * Time.deltaTime;
            m_lookAround.y += rotate.x * scaledRotateSpeed;
            m_lookAround.x += Mathf.Clamp(m_lookAround.x - rotate.y * scaledRotateSpeed, -89, 89);
            rotAngle = m_lookAround.x * 180 / Mathf.PI / 2000;
            rollAngle = m_lookAround.y * 180 / Mathf.PI / 2000;
            transform.forward = new Vector3(mainCamera.GetComponent<Transform>().forward.x, 0, mainCamera.GetComponent<Transform>().forward.z);
            if(mainCamera.GetComponent<CameraFlow>().rollAngle + rollAngle > 0 && mainCamera.GetComponent<CameraFlow>().rollAngle + rollAngle < 85)
            {
                mainCamera.GetComponent<CameraFlow>().rollAngle += rollAngle;
            }
            mainCamera.GetComponent<CameraFlow>().rotAngle += rotAngle;
            
        }
        private void Jump(bool jumpStatu)
        {
            if(jumpStatu)
            {
                targetPos = new Vector3(transform.position.x, transform.position.y + m_Jump, transform.position.z);
            }


        }
        
        public void Update()
        {
            // Move First AND Rotate;
            Jump(m_jumpStatu);
            Move(m_Move);
            LookAround(m_lookAround);
        }
    }
}