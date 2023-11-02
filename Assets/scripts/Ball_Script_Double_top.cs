using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Ball_Script_Double_top : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 1.5f;
    public float xSpeed;
    public float ySpeed;
    public TMP_Text scoreField;
    private int LeftScore = 0;
    private int RightScore = 0;
    public int topScore = 10;

    private void resetBall (string leftOrRight)
    {
        Xposition = 0f; 
        Yposition = 0f;

        scoreField.text = $"{LeftScore} - {RightScore}";
        if(leftOrRight == "left")
        {
            xSpeed = 3f;
            ySpeed = 3f;
        }
        else if (leftOrRight == "right") 
        {
            xSpeed = -3f;
            ySpeed = 3f;
        }
    }

    // setting speed
    void Start()
    {
        transform.position= new Vector3(Xposition, Yposition, 0);
        xSpeed = 3f;
        ySpeed = 3f;

    }

    // Speed Fix
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;

        transform.position = new Vector3(Xposition, Yposition, 0);
        if (LeftScore>= topScore)
        {
            scoreField.text = "Left player has won!";
            xSpeed = 0f;
            ySpeed = 0f;
            Yposition= 0f;
            Xposition = 0f;
        }

        else if (RightScore>=topScore)
        {
            scoreField.text = "Right player has won!";
            xSpeed = 0f;
            ySpeed = 0f;
            Yposition = 0f;
            Xposition = 0f;
        }

    }

    //to do on impact
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            ySpeed = ySpeed * -1f;

        }

        if (collision.gameObject.CompareTag("leftWall"))
        {
           
            RightScore++;
           resetBall("left");
        }
        if (collision.gameObject.CompareTag("rightWall"))
        {
            
            LeftScore++;
            resetBall("right");

        }
        if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.1f;
        }

    }
}
