using UnityEngine;
using MLAgents;
using MLAgents.Sensors;

public class Robot : Agent
{
    public float timer = 7200;
    public float speed = 10;
    private Rigidbody rigRobot;
    public Rigidbody rigCoin1;

    public int time = 180;
    public static bool timeCheck = false;
    public static bool check = true;

    private void Start()
    {
        rigRobot = GetComponent<Rigidbody>();

        InvokeRepeating("TimeClock", 1f, 1f);

    }
    public override void OnEpisodeBegin()
    {
        rigRobot.velocity = Vector3.zero;
        rigRobot.angularVelocity = Vector3.zero;
        Vector3 posRobot = new Vector3(-24.8f, 2.63f, -24.7f);
        transform.position = posRobot;
        Final.complete = false;
    }
    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.position);
        sensor.AddObservation(rigRobot.velocity.x);
        sensor.AddObservation(rigRobot.velocity.z);

        sensor.AddObservation(rigCoin1.position);

    }

    //加扣分">~<"
    public override void OnActionReceived(float[] vectorAction)
    {
        Vector3 control = Vector3.zero;
        control.x = vectorAction[0];
        control.z = vectorAction[1];
        rigRobot.AddForce(control * speed);

        if(Final.complete)
        {
            SetReward(1.0f);
            EndEpisode();
            timeCheck = false;
            time = 100;
            check = false;
            Coin1.a = 1;
        }

        /*if(Coin1.a == 2)
        {
            SetReward(0.5f);
        }
        if (Coin1.a == 3)
        {
            SetReward(0.5f);
        }
        if (Coin1.a == 4)
        {
            SetReward(0.5f);
        }*/

        if (timeCheck == true || rigRobot.position.y<0)
        {
            SetReward(-1.0f);
            EndEpisode();
            timeCheck = false;
            time = 180;
            check = false;
            Coin1.a = 1;
        }

        if(Trap.trap == false)
        {
            SetReward(-0.5f);
        }
    }

    public override float[] Heuristic()
    {
        var action = new float[2];
        action[0] = Input.GetAxis("Horizontal");
        action[1] = Input.GetAxis("Vertical");
        return action;
    }

    public void TimeClock()
    {
        if(time == 0)
        {
            timeCheck = true;
        }
        else
        {
            time -= 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Coin1")
        {
            SetReward(0.2f);
        }

        /*if(collision.gameObject.tag == "Trap")
        {
            SetReward(-0.1f);
        }*/
    }

}
