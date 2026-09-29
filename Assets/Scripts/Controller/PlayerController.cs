using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterclockwiseKey;

    public override void Start()
    {
        
    }

    public override void Update()
    {
        base.Update();
    }

    public override void MakeDecisions()
    {
        if (Input.GetKey(moveForwardKey))
        {

        }

        if (Input.GetKey(moveBackwardKey))
        {

        }

        if (Input.GetKey(rotateClockwiseKey))
        {

        }

        if (Input.GetKey(rotateCounterclockwiseKey))
        {

        }
    }
}
