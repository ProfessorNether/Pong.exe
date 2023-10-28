using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong_AI : MonoBehaviour
{
    public float ySpeed = 7f;
    public float yPosition = 0;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
   {
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3 (transform.position.x, ball.transform.position.y/ ySpeed, transform.position.z);
        transform.position = new Vector3(transform.position.x, ball.transform.position.y, transform.position.z);
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
