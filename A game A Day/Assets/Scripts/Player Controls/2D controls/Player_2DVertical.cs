using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2DVertical : MonoBehaviour
{
    public KeyCode left, left_alt, right, right_alt;
    public float speed;

    int direction;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left) || Input.GetKey(left_alt))
        {
            direction = -1;
        }
        else if (Input.GetKey(right) || Input.GetKey(right_alt))
        {
            direction = 1;
        }
        else
        {
            direction = 0;
        }


        transform.Translate(direction * speed * Time.deltaTime, 0, 0);
    }
}
