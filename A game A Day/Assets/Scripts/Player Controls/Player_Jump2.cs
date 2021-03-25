using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump2 : MonoBehaviour
{
    public KeyCode jumpButton;
    public float groundDistance, jumpForce;
    public Transform ground_Check;
    public LayerMask ground;

    bool onGround;


    // Update is called once per frame
    void Update()
    {
        onGround = Physics.CheckSphere(ground_Check.position, groundDistance, ground);

        if (onGround)
        {
            if (Input.GetKeyDown(jumpButton))
            {
                this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
            }
        }
    }
}
