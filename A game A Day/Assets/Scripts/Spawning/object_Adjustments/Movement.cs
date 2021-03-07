using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool x, y, z;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (x)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (y)
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        if (z)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }
}
