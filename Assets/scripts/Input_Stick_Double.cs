using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Input_Stick_Double : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;

    // Start is called before the first frame update
    void Start()
    {


    }
    // transform.position.y > 
    //stick movements
    void Update()
    {
        //Left Paddle
        if (leftOrRight == "Left1")
        {
            //kleiner dan
            if (Input.GetKey(KeyCode.S) && (transform.position.y < 4.25f))
            {

                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            //groter dan
            else if (Input.GetKey(KeyCode.W) && (transform.position.y > 0.75f))
            {

                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

        else if (leftOrRight == "Left2")
        {
            if (Input.GetKey(KeyCode.W) && (transform.position.y < -0.75f))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            else if (Input.GetKey(KeyCode.S) && (transform.position.y > -4.25f))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
            //Right Paddle
        if (leftOrRight == "Right1")
        {
            if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y < 4.25f))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            else if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y > 0.75f))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

        else if (leftOrRight == "Right2")
        {
            if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y < -0.75f))
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            else if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y > -4.25f))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
}
