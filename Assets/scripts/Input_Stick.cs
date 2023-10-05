using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Stick : MonoBehaviour
{
    public float speed = 3f;
    public string leftOrRight;

    // Start is called before the first frame update
    void Start()
    {
      
        
    }

    //stick movements
    void Update()
    {
        if (leftOrRight == "Left")
        {
            if (Input.GetKey(KeyCode.S))
            {
                Debug.Log("S is Pressed");
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                Debug.Log("W is Pressed");
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

        else if (leftOrRight == "Right")
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Debug.Log("downarrow is pressed");
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("uparrow is Pressed");
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }


    }
}
