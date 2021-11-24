//Script was made in ILE 1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float speed = 100.0f;//camera speed
    public Transform player;//Empty body of the player
    float updown = 0.0f;//Variable for looking up and down

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//Makes the mouse stay in place
    }

    // Update is called once per frame
    void Update()
    {
        float xaxis = Input.GetAxis("Mouse X") * speed * Time.deltaTime;//movement variable for x
        float yaxis = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;//movement variable for y
        
        player.Rotate(Vector3.up * xaxis);//camera movement for looking left and right
        updown -= yaxis;
        updown = Mathf.Clamp(updown, -90.0f, 90.0f);//clamps for rotation on the x axis so you cant look behind you by moving mouse up or down
        
        transform.localRotation = Quaternion.Euler(updown, 0.0f, 0.0f);//camera movement for looking up and down

    }
}
