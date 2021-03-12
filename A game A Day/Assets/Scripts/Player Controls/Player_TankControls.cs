using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_TankControls : MonoBehaviour
{
    public float walkSpeed;

    public KeyCode forward;
    public KeyCode forward_alt;
    public KeyCode backward;
    public KeyCode backward_alt;

    public float turnSpeed;

    public KeyCode leftRotation;
    public KeyCode leftRotation_alt;
    public KeyCode rightRotation;
    public KeyCode rightRotation_alt;

    public float speedMultiplier;
    public KeyCode sprint;
    public KeyCode sprint_alt;

    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = walkSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(sprint) || Input.GetKey(sprint_alt))
        {
            speed *= speedMultiplier;
        }

        if(Input.GetKey(forward) || Input.GetKey(forward_alt))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        else if (Input.GetKey(backward) || Input.GetKey(backward_alt))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }

        if (Input.GetKey(leftRotation) || Input.GetKey(leftRotation_alt))
        {
            transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f);
        }
        else if(Input.GetKey(rightRotation) || Input.GetKey(rightRotation_alt))
        {
            transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
        }

        speed = walkSpeed;
    }
}
