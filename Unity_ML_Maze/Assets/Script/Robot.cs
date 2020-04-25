using UnityEngine;
using MLAgents;
using MLAgents.Sensors;

public class Robot : Agent
{
    public static bool TimeCheck = true;
    public float timer = 7200;
    public float speed = 10;
    private Rigidbody rigRobot;
    //public Rigidbody rigCoin1;

    /*private Rigidbody rigCoin4;
    private Rigidbody rigCoin8;
    private Rigidbody rigCoin11;*/
    

    /*public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            TimeCheck = false;
        }
    }*/


    private void Start()
    {
        rigRobot = GetComponent<Rigidbody>();
        
        /*if (rigCoin1 == GameObject.Find("Coin1").GetComponent<Rigidbody>())
        {
            print("52526335");
        }*/
        /*rigCoin4 = GameObject.Find("Coin4").GetComponent<Rigidbody>();
        rigCoin8 = GameObject.Find("Coin8").GetComponent<Rigidbody>();
        rigCoin11 = GameObject.Find("Coin11").GetComponent<Rigidbody>();*/
        

    }
    public override void OnEpisodeBegin()// the game restart environment
    {
        rigRobot.velocity = Vector3.zero;
        rigRobot.angularVelocity = Vector3.zero;
        Vector3 posRobot = new Vector3(-24.8f, 2.63f, -24.7f);
        transform.position = posRobot;
        Final.complete = false;
        //Update();
    }
    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.position);
        sensor.AddObservation(rigRobot.velocity.x);
        sensor.AddObservation(rigRobot.velocity.z);

        /*if (Final.Coin1 == false)
        {
            sensor.AddObservation(rigCoin1.position);
        }*/
        //sensor.AddObservation(rigCoin1.position);
        /*else if(Final.Coin4 == false)
        {
            sensor.AddObservation(rigCoin4.position);
        }
        else if(Final.Coin8 == false)
        {
            sensor.AddObservation(rigCoin8.position);
        }
        else if(Final.Coin11 == false)
        {
            sensor.AddObservation(rigCoin11.position);
        }*/

    }

    public override void OnActionReceived(float[] vectorAction)
    {
        Vector3 control = Vector3.zero;
        control.x = vectorAction[0];
        control.z = vectorAction[1];
        rigRobot.AddForce(control * speed);

        if(Final.complete)
        {
            SetReward(1);
            EndEpisode();
        }
        /*if( rigRobot.position.y<0)
        {
            SetReward(-1);
            EndEpisode();
        }*/
    }

    public override float[] Heuristic()
    {
        var action = new float[2];
        action[0] = Input.GetAxis("Horizontal");
        action[1] = Input.GetAxis("Vertical");
        return action;
    }
    
}
