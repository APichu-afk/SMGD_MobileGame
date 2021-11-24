using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempmonstermove : MonoBehaviour
{
    public CharacterController player;//gets the character controller
    public float speed = 5.0f;//speed of the character movement
    public float gravity = 15.0f;//Gravity intensity
    private Vector3 movementDirection = Vector3.zero;
    private float up;
    private float down;
    private float left;
    private float right;
    private float timer = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            up = 1.0f;
            down = 0.0f;
            left = 0.0f;
            right = 0.0f;
        }
        else if (Input.GetKey(KeyCode.K))
        {
            up = 0.0f;
            down = 1.0f;
            left = 0.0f;
            right = 0.0f;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            up = 0.0f;
            down = 0.0f;
            left = 0.0f;
            right = 1.0f;
        }
        else if (Input.GetKey(KeyCode.J))
        {
            up = 0.0f;
            down = 0.0f;
            left = 1.0f;
            right = 0.0f;
        }
        else
        {
            up = 0.0f;
            down = 0.0f;
            left = 0.0f;
            right = 0.0f;
        }

        movementDirection = new Vector3(-left + right, 0, up + -down);
        movementDirection = transform.TransformDirection(movementDirection);

        movementDirection *= speed;

        movementDirection.y -= gravity;

        player.Move(movementDirection * Time.deltaTime);
    }
}
