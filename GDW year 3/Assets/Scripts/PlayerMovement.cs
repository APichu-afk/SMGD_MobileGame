//Base script was made in ILE 1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController player;//gets the character controller
    public float speed = 5.0f;//speed of the character movement
    public float gravity = 15.0f;//Gravity intensity
    private Vector3 movementDirection = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movementDirection = transform.TransformDirection(movementDirection);

        movementDirection *= speed;

        movementDirection.y -= gravity;

        player.Move(movementDirection * Time.deltaTime);


        //float hori = Input.GetAxis("Horizontal");//Geting input for the x axis
        //float vert = Input.GetAxis("Vertical");//Getimg input for the z axis

        //player.Move((transform.right * hori + transform.forward * vert)* speed * Time.deltaTime);//Movement on the x and z axis
    }
}
