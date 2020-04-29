using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin4 : MonoBehaviour
{
    public Rigidbody rigCoin4;
    public static int b = 1;

    public static bool touch = false;



    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Robot")
        {
            print("Yes");
            b += 1;
            if (b == 2)
            {
                Update();
            }
            else if (b == 3)
            {
                //Update();
            }
            else if (b == 4)
            {
                //Update();

            }

        }
    }

    private void Update()
    {
        /*if(Robot.check == false)
        {
            Vector3 Coin1 = new Vector3(-15.3f, 1.3f, -24.4f);
            rigCoin1.position = Coin1;
            
        }
        else
        {*/
        if (b == 1)
        {
            Vector3 Coin1 = new Vector3(-5f, 1.3f, 15.2f);
            rigCoin4.position = Coin1;
            rigCoin4.velocity = Vector3.zero;
            rigCoin4.angularVelocity = Vector3.zero;
        }
        else if (b == 2)
        {
            Vector3 Coin1 = new Vector3(0f, 1.3f, 25.9f);
            rigCoin4.position = Coin1;
            rigCoin4.velocity = Vector3.zero;
            rigCoin4.angularVelocity = Vector3.zero;
        }
        //}

    }

}
