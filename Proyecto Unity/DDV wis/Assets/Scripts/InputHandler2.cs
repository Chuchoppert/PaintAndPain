﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler2 : MonoBehaviour
{
    public Vector2 InputVector { get; private set; }
    float h;
    float v;


    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            h = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            h = 1;
        }
        else
        {
            h = 0;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v = -1;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            v = 1;
        }
        else
        {
            v = 0;
        }

        InputVector = new Vector2(h, v);

    }
}
