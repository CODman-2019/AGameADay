using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Verticle2DGravityflip : MonoBehaviour
{
    public float lift_Force;

    float gravity;
    Rigidbody rb;
    bool flipGravity;

    // Start is called before the first frame update
    void Start()
    {
        flipGravity = false;
        rb = this.GetComponent<Rigidbody>();
        gravity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Flip();

        switch (flipGravity)
        {
            case true:
                gravity = lift_Force;
                break;
            case false:
                gravity = 0f;
                break;
        }

        rb.AddForce(new Vector3(0, gravity, 0), ForceMode.Impulse);

    }

    void Flip()
    {
        if (flipGravity) flipGravity = false;
        else { flipGravity = true; }
    }
}
