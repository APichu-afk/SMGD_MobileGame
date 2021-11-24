using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public CharacterController player;//gets the character controller
    public float speed = 5.0f;//speed of the character movement
    public float gravity = 15.0f;//Gravity intensity
    private Vector3 movementDirection = Vector3.zero;
    private Vector2 moveinput;
    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector3(moveinput.x, 0, moveinput.y);
        movementDirection = transform.TransformDirection(movementDirection);

        movementDirection *= speed;

        movementDirection.y -= gravity;

        player.Move(movementDirection * Time.deltaTime);
    }

    public void Onmove(InputAction.CallbackContext ctx) => moveinput = ctx.ReadValue<Vector2>();
}
