using UnityEngine;
using System.Collections;
using Platformer2D_3D;

namespace Platformer2D_3D
{
    public class Player2D : MonoBehaviour
    {
        public KeyCode              Left; 
        public KeyCode              Right;
        public KeyCode              Jump;
        public KeyCode              Run;

        private Transform           trans;
        private CharacterController controller;
        private PlayerContainer     container;
        private Vector3             moveDirection; 

        void Start()
        {
            trans = transform;
            controller = GetComponent<CharacterController>();
            container = GetComponent<PlayerContainer>();
            moveDirection = Vector3.zero;
        }

        void Update()
        {
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
                moveDirection = trans.TransformDirection(moveDirection);
                moveDirection *= container.speed;
                if (Input.GetKey(Jump))
                    moveDirection.y = container.jumpSpeed;
            }

            if (Input.GetKey(Right))
                moveDirection.x = container.speed;
            if (Input.GetKey(Left))
                moveDirection.x = -container.speed;
            if (Input.GetKey(Run))
                container.speed = 6;
            if (Input.GetKeyUp(Run))
                container.speed = 3;
            

            moveDirection.y -= container.gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}