using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Input_Stick : MonoBehaviour
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
        if (leftOrRight == "Left")
        { 
            if (Input.GetKey(KeyCode.S) && (transform.position.y < 4))
            {
               
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W) && (transform.position.y > -4))
            {
                
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }

        else if (leftOrRight == "Right")
        {
            if (Input.GetKey(KeyCode.DownArrow) && (transform.position.y < 4))
            {
             transform.Translate(Vector3.up * speed * Time.deltaTime);
            }

            else if (Input.GetKey(KeyCode.UpArrow) && (transform.position.y > -4))
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
    }
}
