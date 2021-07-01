using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBound : MonoBehaviour
{
    public float minX = -2.35f, maxX = 2.35f, minY = -6f;
    private bool outBounds = false;

    void Update()
    {
        CheckBounds();
    }

    void CheckBounds()
    {
        Vector2 temp = transform.position;

        if (temp.x>maxX)
        {
            temp.x = maxX;
           
        }

        if (temp.x < minX)
        {
            temp.x = minX;
            
        }
        transform.position = temp;
        if (temp.y <= minY)
        {
            if (!outBounds)
            {
                outBounds = true;
                //SoundManger.instance.DeathSound();
                //GameManger.instance.RestartGame();
            }
        }
    }
}
