using UnityEngine;
using System.Collections;

public class OwlMovements : MonoBehaviour
{
    public float    speed = 6.0F;
    public float    jumpSpeed = 8.0F;
    public float    gravity = 20.0F;

    private Vector3                 moveDirection;
    private CharacterController     playerController;

	void Start ()
    {
        moveDirection = Vector3.zero;
        playerController = GetComponent<CharacterController>();
	}

    void Update()
    {
        if (playerController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        playerController.Move(moveDirection * Time.deltaTime);
    }
}
