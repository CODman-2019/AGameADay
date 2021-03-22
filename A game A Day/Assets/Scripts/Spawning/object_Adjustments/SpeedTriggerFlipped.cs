using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriggerFlipped : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<Movement>().speed *= -1;
            gameObject.transform.Translate(0f, 0f, 1f);
        }
    }
}
