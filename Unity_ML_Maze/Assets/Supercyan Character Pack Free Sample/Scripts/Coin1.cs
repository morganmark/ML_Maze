using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin1 : MonoBehaviour
{
    public Rigidbody rigCoin1;
    int a = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Robot")
        {
            print("Yes");
            a += 1;
            if (a == 2)
            {
                Vector3 Coin1 = new Vector3(-10.2f, 0.6f, -0.9f);
                rigCoin1.position = Coin1;
                rigCoin1.velocity = Vector3.zero;
                rigCoin1.angularVelocity = Vector3.zero;
            }
            else if (a == 3)
            {
                Vector3 Coin1 = new Vector3(10f, 0.6f, 19.4f);
                rigCoin1.position = Coin1;
                rigCoin1.velocity = Vector3.zero;
                rigCoin1.angularVelocity = Vector3.zero;
            }
            else if (a == 4)
            {
                Vector3 Coin1 = new Vector3(29.8f, 0.6f, -15.81f);
                rigCoin1.position = Coin1;
                rigCoin1.velocity = Vector3.zero;
                rigCoin1.angularVelocity = Vector3.zero;
            }

        }
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Robot")
        {
            print("Yes");
            a += 1;
            if (a == 2)
            {
                Vector3 Coin1 = new Vector3(-10.2f, -15.81f, -0.9f);
                rigCoin1.position = Coin1;
            }
            else if (a == 3)
            {
                Vector3 Coin1 = new Vector3(10f, -15.81f, 19.4f);
                rigCoin1.position = Coin1;
            }
            else if (a == 4)
            {
                Vector3 Coin1 = new Vector3(29.8f, -15.81f, -15.81f);
                rigCoin1.position = Coin1;
            }

        }
    }*/
}
