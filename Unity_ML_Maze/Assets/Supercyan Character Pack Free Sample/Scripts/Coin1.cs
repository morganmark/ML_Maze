using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin1 : MonoBehaviour
{
    public Rigidbody rigCoin1;
    public static int a = 1;

    public static bool touch = false;
    
    

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Robot")
        {
            print("Yes");
            a += 1;
            if (a == 2)
            {
                Update();
            }
            else if (a == 3)
            {
                //Update();
            }
            else if (a == 4)
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
            if(a == 1)
            {
                Vector3 Coin1 = new Vector3(-15.3f, 1.3f, -24.4f);
                rigCoin1.position = Coin1;
                rigCoin1.velocity = Vector3.zero;
                rigCoin1.angularVelocity = Vector3.zero;
        }
            else if (a == 2)
            {
                Vector3 Coin1 = new Vector3(-13.5f, 1.3f, -1.3f);
                rigCoin1.position = Coin1;
                rigCoin1.velocity = Vector3.zero;
                rigCoin1.angularVelocity = Vector3.zero;
        }
            else if (a == 3)
            {
                Vector3 Coin1 = new Vector3(-5f, 1.3f, 25f);
                rigCoin1.position = Coin1;
                rigCoin1.velocity = Vector3.zero;
                rigCoin1.angularVelocity = Vector3.zero;
        }
            else if (a == 4)
            {
                Vector3 Coin1 = new Vector3(27f, 1.3f, 17.5f);
                rigCoin1.position = Coin1;
                rigCoin1.velocity = Vector3.zero;
                rigCoin1.angularVelocity = Vector3.zero;
        }
        //}

    }

}
