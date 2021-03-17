using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationReset : MonoBehaviour
{
    public KeyCode button;
    public float resetPercent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(button))
        {
            gameObject.transform.Rotate(-gameObject.transform.rotation.x * resetPercent, -gameObject.transform.rotation.y * resetPercent, -gameObject.transform.rotation.z * resetPercent);

        }
    }
}
