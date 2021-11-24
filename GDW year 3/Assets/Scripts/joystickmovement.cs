using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystickmovement : MonoBehaviour
{
    public AudioSource walkAudio;
    public Joystick joystick;
    public CharacterController player;
    Vector3 movementDirection;
    public float gravity = 15.0f;//Gravity intensity
    public float speed;
    Vector3 lastPosition = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        //walkAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        float hori = joystick.Horizontal;
        float vert = joystick.Vertical;
        movementDirection = new Vector3(hori, 0, vert);
        movementDirection = transform.TransformDirection(movementDirection);

        movementDirection *= speed;

        movementDirection.y -= gravity;

        player.Move(movementDirection * Time.deltaTime);

        //audio
        if (lastPosition != gameObject.transform.position)
        {
            walkAudio.Play();
        }
        else
        {
            walkAudio.Stop();
        }
        lastPosition = gameObject.transform.position;

    }
}
