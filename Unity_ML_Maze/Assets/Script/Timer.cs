using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public static bool TimeCheck = true;
    public float timer = 7200;
    

    // Update is called once per frame
    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            TimeCheck = false;
        }
    }
}
