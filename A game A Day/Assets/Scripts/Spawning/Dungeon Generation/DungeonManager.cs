using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonManager : MonoBehaviour
{
    public static DungeonManager floor;
    public bool IsSingleton;
    public int roomLimit;
    int roomsUsed = 0;
    bool spawnRooms;

    // Start is called before the first frame update
    void Awake()
    {
        SingletonizeDungeonManager();
        spawnRooms = true;
    }

    private void SingletonizeDungeonManager()
    {
        if (floor == null)
        {
            floor = this;
        }
        else Destroy(gameObject);
    }

    public void RoomIncrease() {
        if (roomsUsed >= roomLimit) spawnRooms = false;
        else
        {
            spawnRooms = true;
            roomsUsed++;
        }
    }
    public void RoomDecrease()
    {
        roomsUsed--;
    }

    public bool CheckR_Limit() => spawnRooms;

    // Update is called once per frame
    //void Update()
    //{

    //}
}
