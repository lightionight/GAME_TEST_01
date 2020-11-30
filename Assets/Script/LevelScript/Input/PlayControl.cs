using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace GAME_TEST_01.Player
{
    //[RequireComponent(typeof(PlayerInput))]
    public class PlayControl : MonoBehaviour
    {
        public float moveSpeed = 1;
        private Vector2 m_move;
        //creat action
        public InputAction moveAction;

        private void Start()
        {
            moveAction.Enable();
        }
        public void Update()
        {
            var moveDir = moveAction.ReadValue<Vector2>();
            //掌握移动物体的多种方法
            var moveDistance = Quaternion.Euler(0, transform.eulerAngles.y, 0) * new Vector3(moveDir.x, 0, moveDir.y);
            transform.position += moveDistance * moveSpeed * Time.deltaTime;
            //Debug.Log(transform.position);
        }

    }
}

