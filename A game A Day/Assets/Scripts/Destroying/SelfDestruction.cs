using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruction : MonoBehaviour
{
    [Header("if randTimer not used - timeMin wll be used")]
    public bool randTimer;
    public float timeMin, timeMax;

    float timer;

    // Start is called before the first frame update
    void Awake()
    {
        float time = timeMin;
        if(randTimer) time = Random.Range(timeMin, timeMax);

        timer = Time.time + time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer) SelfDestroy();
    }

    void SelfDestroy()
    {
        Destroy(this.gameObject);
    }
}
