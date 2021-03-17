using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointSpawning : MonoBehaviour
{
    GameObject checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            checkpoint = other.gameObject;
        }

        if (other.CompareTag("Killzone"))
        {
            this.gameObject.transform.position = checkpoint.transform.position;
        }
    }
}
