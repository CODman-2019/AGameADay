using System.Collections;
using UnityEngine;

public class RoomSpawn : MonoBehaviour
{
    public GameObject[] roomSelection;
    bool roomPlaced;
    //float timer = 100f;

    // Start is called before the first frame update
    void Start()
    {
        roomPlaced = false;
        PlaceRoom();
    }


    void PlaceRoom()
    {
        if (DungeonManager.floor.CheckR_Limit())
        {
            StartCoroutine(Wait());
            int roomNum = Random.Range(0, roomSelection.Length);
            Instantiate(roomSelection[roomNum], gameObject.transform);
            roomPlaced = true;
            DungeonManager.floor.RoomIncrease();
        }
    }

    bool IsPlaced() => roomPlaced;

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(100f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Room"))
        {
            Debug.Log(other.gameObject);
            DungeonManager.floor.RoomDecrease();
            Destroy(this.gameObject);
        }

    }

}
