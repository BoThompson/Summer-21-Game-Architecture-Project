using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = Vector3.zero;
        //If player presses up arrow:
        if (Input.GetKey(KeyCode.UpArrow))
            //Move player into background
            v += Vector3.forward * speed;
        //If player presses down arrow:
        if(Input.GetKey(KeyCode.DownArrow))
            //Move player into foreground
            v += Vector3.back * speed;
        //If player presses left arrow:
        if (Input.GetKey(KeyCode.LeftArrow))
            //Move player into left
            v += Vector3.left * speed;
        //If player presses right arrow:
        if (Input.GetKey(KeyCode.RightArrow))
            //Move player into right
            v += Vector3.right * speed;
        rigidbody.velocity = v;
    }
}
