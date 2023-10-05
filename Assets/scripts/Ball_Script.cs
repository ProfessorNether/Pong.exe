using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed;
    public float ySpeed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position= new Vector3(Xposition, Yposition, 0);
        xSpeed = 2f;
        ySpeed = 2f;

    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;

        transform.position = new Vector3(Xposition, Yposition, 0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            ySpeed = ySpeed * -1;
            Debug.Log("Touched horizontal wall");
        }

        if (collision.gameObject.CompareTag("VerticalWall"))
        {
            xSpeed = xSpeed * -1;
            Debug.Log("Touched vertical wall");
        }
    }
}
