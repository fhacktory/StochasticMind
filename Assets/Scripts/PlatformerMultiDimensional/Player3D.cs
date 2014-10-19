using UnityEngine;
using System.Collections;

namespace Platformer2D_3D
{
    public class Player3D : MonoBehaviour {

        public KeyCode  Up;
        public KeyCode  Down;
        public KeyCode  Left;
        public KeyCode  Right;
        public KeyCode  Jump;
        public KeyCode  Run;

        private Transform trans;
        private CharacterController controller;
        private Vector3 moveDirection;
        private PlayerContainer container;

	    // Use this for initializatio
	    void Start () {
            trans = transform;
            controller = GetComponent<CharacterController>();
            container = GetComponent<PlayerContainer>();
	    }
	
	    // Update is called once per frame
	    void Update () {
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
                moveDirection = trans.TransformDirection(moveDirection);
                moveDirection *= container.speed;
                if (Input.GetKey(Jump))
                    moveDirection.y = container.jumpSpeed;
            }

            if (Input.GetKey(Up))
                moveDirection.x = container.speed;
            if (Input.GetKey(Down))
                moveDirection.x = -container.speed;
            if (Input.GetKey(Left))
                moveDirection.z = container.speed;
            if (Input.GetKey(Right))
                moveDirection.z = -container.speed;
            if (Input.GetKey(Run))
                container.speed = 6;
            if (Input.GetKeyUp(Run))
                container.speed = 3;


            moveDirection.y -= container.gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
	    }
    }
}