using UnityEngine;
using System.Collections;

namespace Platformer2D_3D
{
    public class Player : MonoBehaviour
    {
        public KeyCode              Left; 
        public KeyCode              Right;
        public KeyCode              Jump;

        private Transform           trans;
        private CharacterController controller;
        private int                 speed;
        private int                 jumpSpeed;
        private float               gravity;
        private Vector3             moveDirection; 

        void Start()
        {
            trans = transform;
            controller = GetComponent<CharacterController>();
            speed = 5;
            jumpSpeed = 6;
            gravity = 10.0f;
            moveDirection = Vector3.zero;
        }

        void Update()
        {
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
                moveDirection = trans.TransformDirection(moveDirection);
                moveDirection *= speed;
                if (Input.GetKey(Jump))
                    moveDirection.y = jumpSpeed;
            }

            if (Input.GetKey(Right))
                moveDirection.x = speed;
            if (Input.GetKey(Left))
                moveDirection.x = -speed;

            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}