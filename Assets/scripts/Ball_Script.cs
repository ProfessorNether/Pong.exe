using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position= new Vector3(Xposition, Yposition, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Xposition = Xposition + 2.5f * Time.deltaTime;
        Yposition = Yposition + 2.5f * Time.deltaTime;

        transform.position = new Vector3(Xposition, Yposition, 0);

    }
}
