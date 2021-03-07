using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainObjectSpawner : MonoBehaviour
{
    public GameObject obj;
    public float minSpawn, maxSpawn, timer;

    float timeSet;
    // Start is called before the first frame update
    void Start()
    {
        timeSet = Time.time + timer;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeSet)
        {
            Instantiate(obj);
            Vector3 pos = new Vector3(Random.Range(minSpawn, maxSpawn), transform.position.y, 0f);
            obj.transform.position = pos;
            timeSet = Time.time + timer;
        }

    }
}
