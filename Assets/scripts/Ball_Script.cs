using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed;
    public float ySpeed;

    // setting speed
    void Start()
    {
        transform.position= new Vector3(Xposition, Yposition, 0);
        xSpeed = 5f;
        ySpeed = 5f;

    }

    // Speed Fix
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;

        transform.position = new Vector3(Xposition, Yposition, 0);

    }

    //to do on impact
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            ySpeed = ySpeed * -1;
            Debug.Log("Touched horizontal wall");
        }

        if (collision.gameObject.CompareTag("VerticalWall") || collision.gameObject.CompareTag("Stick"))
        {
            xSpeed = xSpeed * -1;
            Debug.Log("Touched vertical wall");
        }
    }
}
