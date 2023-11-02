using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong_AI : MonoBehaviour
{
    //sets the speed of the AI
    public float ySpeed = 100000000000f;

    //Y should not move so it is 0
    public float yPosition = 0;

    //reference the gameobject ball in the code
    public GameObject ball;

    // Update is called once per frame
    void Update()
   {
        yPosition = yPosition + ySpeed * Time.deltaTime;
        //takes the ball as a reference
        transform.position = new Vector3 (transform.position.x, ball.transform.position.y/ ySpeed, transform.position.z);
        transform.position = new Vector3 (transform.position.x, ball.transform.position.y, transform.position.z);
        if (yPosition >= 4)
        {
            ySpeed = ySpeed * -1f;
        }
        else if (yPosition <= -4)
        {
            ySpeed = ySpeed * -1f;
        }

    }
}
