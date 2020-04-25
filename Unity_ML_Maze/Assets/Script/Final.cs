using UnityEngine;

public class Final : MonoBehaviour
{
    public static bool complete;
    public static bool Coin1;
    public static bool Coin4;
    public static bool Coin8;
    public static bool Coin11;

    
    //public Rigidbody rigCoin1;

    int a = 1;

    private void OnTriggerEnter(Collider other) 
    {
        /*if(other.name == "Coin1")
        {
            print("149518945498");
            a += 1;
            if(a == 2)
            {
                Vector3 Coin1 = new Vector3(-10.2f, -15.81f, -0.9f);
                rigCoin1.position = Coin1;
            }
            else if(a == 3)
            {
                Vector3 Coin1 = new Vector3(10f, -15.81f, 19.4f);
                rigCoin1.position = Coin1;
            }
            else if (a == 4)
            {
                Vector3 Coin1 = new Vector3(29.8f, -15.81f, -15.81f);
                rigCoin1.position = Coin1;
            }

        }*/

        /*if (other.name == "Coin1")
        {
            Coin1 = true;
        }
        else if(other.name == "Coin4")
        {
            Coin4 = true;
        } 
        else if (other.name == "Coin8")
        {
            Coin8 = true;
        }
        else if (other.name == "Coin11")
        {
            Coin11 = true;
        }*/
        if (other.name == "Final")
        {
            complete = true;
        }
    }
}
