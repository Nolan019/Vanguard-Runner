using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPlatformScript : MonoBehaviour
{
    public Transform movingPlatform;
    public Transform position1;
    public Transform position2;
    public Transform position3;
    public Transform position4;
    public Vector3 newPosition;
    public string currentState;
    public float smooth;
    public float resetTime;

    // Start is called before the first frame update
    void Start()
    {
        ChangeTarget();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        print(currentState);
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);
    }
    void ChangeTarget()
    {
        if (currentState == "Moving to Position 1")
        {
            currentState = "Moving to Position 2";
            newPosition = position2.position;
        }
        else if (currentState == "Moving to Position 2")
        {
            currentState = "Moving to Position 3";
            newPosition = position3.position;
        }
        else if (currentState == "Moving to Position 3")
        {
            currentState = "Moving to Position 4";
            newPosition = position4.position;
        }
        else if (currentState == "Moving to Position 4")
        {
            currentState = "Moving to Position 1";
            newPosition = position1.position;
        }
        else if (currentState == "")
        {
            currentState = "Moving to Position 1";
            newPosition = position1.position;
        }
        Invoke("ChangeTarget", resetTime);
    }
}
