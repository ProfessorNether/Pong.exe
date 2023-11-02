using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Ball_Script : MonoBehaviour
{
    //Settings for the ball
    //-Move in X and Y coordinates
    //-change directions when the ball hits a player or wall
    //-When the ball hits a player it will go faster by 0.1 speed
    //-score manager for when a ball hits the goal (L or R wall)
    //-Showing the score in a textfield that can increment on goals

    //Variables
    //X and Y Position at start of each round
    public float Xposition = 0f;
    public float Yposition = 0f;
    //X and Y Speed at start of each round
    public float xSpeed;
    public float ySpeed;
    //Scoreboard on top of screen
    //Score manager
    //reference to text object (a link that needs to be connected in unity)
    public TMP_Text scoreField;
    //organising what score is needed on what side on ball hit goal
    private int LeftScore = 0;
    private int RightScore = 0;
    //score cap: when hit the player that scored 10 has won
    public int topScore = 10;

    //function for reset ball on ball scored
    //left or right score different direction start
    private void resetBall (string leftOrRight)
    {
        //starting position X or Y
        Xposition = 0f; 
        Yposition = 0f;

        //shows score in text field, what can be updated
        scoreField.text = $"{LeftScore} - {RightScore}";

        //checks which side has been scored to, if left or right hes been scored to (it will type in the scorefield the right text)
        if(leftOrRight == "left")
        {
            //ball goes right and up
            xSpeed = 3f;
            ySpeed = 3f;
        }
        else if (leftOrRight == "right") 
        {
            //ball goes left and up
            xSpeed = -3f;
            ySpeed = 3f;
        }
    }

    // setting speed
    void Start()
    {
        //Start position of the ball
        transform.position= new Vector3(Xposition, Yposition, 0);

        //Start Speed
        xSpeed = 3f;
        ySpeed = 3f;

    }

    // Update is called once per frame
    void Update()
    {
        //updates the X an Y position with xspeed ans yspeed
        //multiplies with deltatime, every pc or device has the same ball speed because of this
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;

        //updates position with new values
        transform.position = new Vector3(Xposition, Yposition, 0);

        //check if topscore is reached or has gone above it: on hit or higher left or right wins
        //if reached: place in the middle/ stops ball and displays the winner
        //schows winner in textfield (display the winner)
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
    //if the ball hits a wall or player, it will do something (redirect directions)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checks gameobject tag, if it has the right tag it will tell the ball to turn a different direction
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            //change directions of the ball: it basically flips directions vertically
            ySpeed = ySpeed * -1f;

        }

        if (collision.gameObject.CompareTag("leftWall"))
        {
           //Increments the right score by 1 and resets the ball
            RightScore++;
           resetBall("left");
        }
        if (collision.gameObject.CompareTag("rightWall"))
        {
            //increments the left score by 1 and resets the ball
            LeftScore++;
            resetBall("right");

        }
        if (collision.gameObject.CompareTag("Player"))
        {
            //increments speed by 0.1 of its starting value each time on collision and inverts the directions horizontally
            xSpeed = xSpeed * -1.1f;
        }

    }
}
