using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public static bool trap = true;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tag")
        {
            trap = false;
        }
        else
        {
            trap = true;
        }
    }

}
