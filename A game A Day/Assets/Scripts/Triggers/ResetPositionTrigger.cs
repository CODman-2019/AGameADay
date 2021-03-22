using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionTrigger : MonoBehaviour
{
    public GameObject startPoint;
    GameObject checkPoint;
    bool resetPos;
    // Update is called once per frame
    void Update()
    {
        if (resetPos)
        {
            if (checkPoint)
            {
                gameObject.transform.position = checkPoint.transform.position;
            }
            else
            {
                gameObject.transform.position = startPoint.transform.position;
            }
            resetPos = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            checkPoint = other.gameObject;
            //resetPos = false;
        }

        if (other.CompareTag("Killzone"))
        {
            resetPos = true;
        }

        if (other.CompareTag("Endpoint"))
        {
            checkPoint = null;
            resetPos = true;
        }
    }
}
