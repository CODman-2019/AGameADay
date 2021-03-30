using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaChange : MonoBehaviour
{
    public GameObject target;
    [Range(0f, 1f)]
    public float alphaValue;
    public float timer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LeanTween.alpha(target, alphaValue, timer);
        }
    }

    //IEnumerator Timewait()
    //{
    //    yield return new WaitForSeconds(1);
    //    Color alphaChange = target.GetComponent<Renderer>().material.color;
    //    alphaChange.a /= 2;
    //    target.GetComponent<Renderer>().material.color = alphaChange;
    //}
}
