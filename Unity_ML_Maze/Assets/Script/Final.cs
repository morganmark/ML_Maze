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
        if (other.name == "Final")
        {
            complete = true;
        }
    }
}
