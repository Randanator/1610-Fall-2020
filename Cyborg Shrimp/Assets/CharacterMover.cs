using UnityEngine;

public class CharacterMover : MonoBehaviour
{
   public CharacterController controller;
   public float moveSpeed = 5f, gravity = -9.81f, jumpForce = 10f;

   public Vector3 moveDirection;
   private float _yDirection;

   private void Update()
   {
      var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
      moveDirection.Set(moveSpeedInput,_yDirection,0);

      _yDirection += gravity * Time.deltaTime;

      if (controller.isGrounded && moveDirection.y < 0)
      {
         _yDirection = -1f;
      }

      if (Input.GetButtonDown("Jump"))
      {
         _yDirection = jumpForce;
      }

      var movement = moveDirection * Time.deltaTime;
      controller.Move(movement);
   }
}
