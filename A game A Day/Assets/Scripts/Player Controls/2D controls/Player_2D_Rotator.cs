using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2D_Rotator : MonoBehaviour
{
    public bool rotateX, rotateY, rotateZ;
    public float rotateValue;
    public KeyCode xTurnLeft, xTurnRight;
    public KeyCode yTurnLeft, yTurnRight;
    public KeyCode zTurnLeft, zTurnRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateX)
        {
            if (Input.GetKey(xTurnLeft)) transform.Rotate(-rotateValue * Time.deltaTime, 0f, 0f);
            else if (Input.GetKey(xTurnRight)) transform.Rotate(rotateValue * Time.deltaTime, 0f, 0f);
        }

        if (rotateY)
        {
            if (Input.GetKey(yTurnLeft)) transform.Rotate(0f, -rotateValue * Time.deltaTime, 0f);
            else if (Input.GetKey(yTurnRight)) transform.Rotate(0f, rotateValue * Time.deltaTime, 0f);
        }

        if (rotateZ)
        {
            if (Input.GetKey(zTurnLeft)) transform.Rotate(0f, 0f, -rotateValue * Time.deltaTime);
            else if (Input.GetKey(zTurnRight)) transform.Rotate(0f, 0f, rotateValue * Time.deltaTime);
        }
    }
}
