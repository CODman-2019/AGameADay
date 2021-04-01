using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_3DPlatformer : MonoBehaviour
{
    public Transform target;
    public Transform pivot;

    public Vector3 offset;

    public float rotateSpeed;
    public float yMin, yMax;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        offset = target.position - transform.position;
        
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //get x pos of mouse + rotate to target
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        target.Rotate(0, horizontal, 0f);

        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
        float clampedV = Mathf.Clamp(vertical, -90f, 90f);
        pivot.Rotate(-clampedV, 0f, 0f);

        //move camera based on target & OG offset
        float desiredYAngle = target.eulerAngles.y;
        float desiredXAngle = pivot.eulerAngles.x;
        
        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);

        //transform.position = target.position - offset;
        
        transform.LookAt(target);
    }
}
