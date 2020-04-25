using UnityEngine;

public class Final : MonoBehaviour
{
    public static bool complete;
    public static bool Coin1;
    public static bool Coin4;
    public static bool Coin8;
    public static bool Coin11;
    private void OnTriggerEnter(Collider other) 
    {
        if (other.name == "Coin1")
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
        }
        else if (other.name == "Final")
        {
            complete = true;
        }
    }
}
