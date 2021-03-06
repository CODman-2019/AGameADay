using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CYO_2DController : MonoBehaviour
{
    public bool V_x, V_y, V_z;
    public float V_Speed;
    public KeyCode vPositive, vNegative, vPositiveAlt, vNegativeAlt;

    public bool H_x, H_y, H_z;
    public float H_Speed;
    public KeyCode hPositive, hNegative, hPositiveAlt, hNegativeAlt;

    public bool canSprint, sprint_V, sprint_H;
    public KeyCode sprint;
    public float speedModifier;

    float vdir, hdir;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(vPositive) || Input.GetKey(vPositiveAlt))
        {
            vdir = 1;
        }
        else if(Input.GetKey(vNegative) || Input.GetKey(vNegativeAlt))
        {
            vdir = -1;
        }
        else { vdir = 0; }

        if (Input.GetKey(hPositive) || Input.GetKey(hPositiveAlt))
        {
            hdir = 1;
        }
        else if (Input.GetKey(hNegative) || Input.GetKey(hNegativeAlt))
        {
            hdir = -1;
        }
        else { hdir = 0; }


        vdir *= V_Speed * Time.deltaTime;
        hdir *= H_Speed * Time.deltaTime;

        if (canSprint)
        {
            if (Input.GetKey(sprint))
            {
                if (sprint_V) vdir *= speedModifier;
                if (sprint_H) hdir *= speedModifier;
            }
        }

        if (V_x)
        {
            transform.Translate(vdir, 0, 0);
        }
        if (V_y)
        {
            transform.Translate(0, vdir, 0);
        }
        if (V_z)
        {
            transform.Translate(0, 0, vdir);
        }

        if (H_x)
        {
            transform.Translate(hdir, 0, 0);
        }
        if (H_y)
        {
            transform.Translate(0, hdir, 0);
        }
        if (H_z)
        {
            transform.Translate(0, 0, hdir);
        }
    }
}
