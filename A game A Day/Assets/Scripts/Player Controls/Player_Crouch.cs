using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Crouch : MonoBehaviour
{
    public KeyCode input;
    public float crouchScale, standingScale;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(input))
        {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, crouchScale, gameObject.transform.localScale.z);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, standingScale, gameObject.transform.localScale.z);
        }
    }
}
