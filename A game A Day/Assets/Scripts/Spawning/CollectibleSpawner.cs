using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectible;

    public bool xSpawning, ySpawning, zSpawning;

    public float xMin, xMax;
    public float yMin, yMax;
    public float zMin, zMax;

    public float timeSpan;
    float timeSet;

    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        timeSet = Time.time + timeSpan;
        pos = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeSet) {
            if (xSpawning) { pos.x = Random.Range(xMin, xMax); }
            if (ySpawning) { pos.y = Random.Range(yMin, yMax); }
            if (zSpawning) { pos.z = Random.Range(zMin, zMax); }

            Instantiate(collectible);
            collectible.transform.position = pos;
            timeSet = Time.time + timeSpan;
        }
    }
}
