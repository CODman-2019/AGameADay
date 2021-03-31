using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_RETankControls : MonoBehaviour
{
    public float vertical_Speed;
    public KeyCode forwardKey;
    public KeyCode forwardAltKey;
    public KeyCode backwardKey;
    public KeyCode backwardAltKey;

    public float yRotationSpeed;
    public KeyCode leftTurnKey;
    public KeyCode leftTurnAltKey;
    public KeyCode rightTurnKey;
    public KeyCode rightTurnAltKey;

    public bool canSprint;
    public float speedMultiplier;
    public KeyCode sprintKey;
    public KeyCode sprintAltKey;

    float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(forwardKey) || Input.GetKey(forwardAltKey))
        {
            speed = vertical_Speed;
            if (canSprint)
            {
                if(Input.GetKey(sprintKey) || Input.GetKey(sprintAltKey))
                {
                    speed *= speedMultiplier;
                }
            }
            transform.Translate(0f, 0f, speed * Time.deltaTime);
            
        }

        if(Input.GetKey(backwardKey) || Input.GetKey(backwardAltKey))
        {
            speed = -vertical_Speed;
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }

        if(Input.GetKey(rightTurnKey) || Input.GetKey(rightTurnAltKey))
        {
            transform.Rotate(0f, yRotationSpeed * Time.deltaTime, 0f);
        }

        if(Input.GetKey(leftTurnKey) || Input.GetKey(leftTurnAltKey))
        {
            transform.Rotate(0f, -yRotationSpeed * Time.deltaTime, 0f);
        }

        speed = 0;
    }
}
