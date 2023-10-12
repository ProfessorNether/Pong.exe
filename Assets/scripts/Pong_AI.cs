using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong_AI : MonoBehaviour
{
    public float ySpeed = 1f;
    public float yPosition = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3 (transform.position.x, Ball.transform.yPosition/1.5f, transform.position.z);
       
    }
}
