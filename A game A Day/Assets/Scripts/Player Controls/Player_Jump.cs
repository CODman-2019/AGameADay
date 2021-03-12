using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    public KeyCode input;
    public float force;
    [SerializeField]
    inputAction button = inputAction.press;

    enum inputAction
    {
        press,
        hold
    }

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (button)
        {
            case inputAction.press:
                if (Input.GetKeyDown(input))
                {
                    rb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
                }
                break;

            case inputAction.hold:
                if (Input.GetKey(input))
                {
                    rb.AddForce(new Vector3(0, force, 0), ForceMode.Impulse);
                }
                break;
        }

    }
}
