using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //variables for the game to use
    public bool isChar1;
    public float movementPerSecond = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Key variables to make the code work
        float movementAxis = Input.GetAxis("Horizontal");
        Vector3 force = Vector3.right * movementAxis * movementPerSecond * Time.deltaTime;

        // in order to move with out the if statements then I can use the axis
        Transform transform = GetComponent<Transform>();

        Rigidbody rigidB = GetComponent<Rigidbody>();
        //play with velocity and forces

        if (isChar1)
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * movementPerSecond * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * movementPerSecond * Time.deltaTime, 0f);
        }

        //if (rigidB) {
         //   rigidB.AddForce(force, ForceMode.VelocityChange);
       // }
        //transform.position += Vector3.right * movementAxis * movementPerSecond * Time.deltaTime;


        // checks for the game to run
        //if (Input.GetKey(KeyCode.A))
        //{
        //    //Will give the object the ablility to change movement
        //    Transform transform = GetComponent<Transform>();
        //    transform.position += -Vector3.right * movementPerSecond * Time.deltaTime;
//
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
            //Will give the object the ablility to change movement
        //    Transform transform = GetComponent<Transform>();
        //    transform.position += Vector3.right * movementPerSecond * Time.deltaTime;

        //}

    }

    private void OnCollisionEnter(Collision collison)
    {
        //Debug.Log("mover collided with " + collison.gameObject.name);
    }

}


