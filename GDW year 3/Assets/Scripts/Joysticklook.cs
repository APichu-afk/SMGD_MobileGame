using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joysticklook : MonoBehaviour
{
    public Joystick joystick2;
    public Transform position;
    public float camspeed;
    float updown = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xaxis = joystick2.Horizontal * camspeed * Time.deltaTime;
        float yaxis = joystick2.Vertical * camspeed * Time.deltaTime;

        position.Rotate(Vector3.up * xaxis);//camera movement for looking left and right
        updown -= yaxis;
        updown = Mathf.Clamp(updown, -90.0f, 90.0f);//clamps for rotation on the x axis so you cant look behind you by moving mouse up or down

        transform.localRotation = Quaternion.Euler(updown, 0.0f, 0.0f);//camera movement for looking up and down
    }
}
