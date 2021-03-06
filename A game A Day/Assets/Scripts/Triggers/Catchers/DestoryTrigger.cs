using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryTrigger : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //UnityEngine.SceneManagement.SceneManager.Get;
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
