using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    private bool hitObject;

    private bool touchingObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ALL FUNCTIONS UNDER ARE UNITY FUNCTIONS AND WILL AUTOMATICALLY BE CALLED AND GIVEN ITS REQUEST WHEN THIS OBJECT COLLIDES WITH ANOTHER IF BOTH HAVE A COLLIDER AND ONE HAS A RIGIDBODY
    //Whatever is in the function will happen when the collision type happens

    //CALLED THE FRAME THE COLLISION STARTS ON, RESETS AFTER THAT OBJECT STOPS TOUCHING THIS
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitObject = true;
    }

    //CALLED WHILE THE OBJECT IS TOUCHING THIS
    private void OnCollisionStay2D(Collision2D collision)
    {
        touchingObject = true;
    }

    //CALLED THE FRAME THE OBJECT STOPS TOUCHING THIS
    private void OnCollisionExit2D(Collision2D collision)
    {
        touchingObject = false;
        hitObject = false;
    }
}
