using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyScript : MonoBehaviour
{
    public Rigidbody2D rb;

    //VELOCITY IS A MAGNITUDE AND DIRECTION
    //so its a vector which has a direction and a amount so (1,1) is up and right by a magnitude of 1, while (-2,-2) is the opposite direction with double the magnitude


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootUp()
    {
        //AddForce is like pushing something in a direction
        //Setup: rigisbodyVariable.AddForce(direction * speed)
        //dont need to put a speed but usually do
        rb.AddForce(Vector2.up * 10);
    }

    void ChangeVelocity()
    {

       
        //This is how to directly change the objects velocity
        //setup: rb.velocity action
        //rb.velocity is pretty much a variable that already has an effect in game
        rb.velocity *= 2;
        //this will double their velocity

        
        rb.velocity = new Vector2(0, 0);
        //this will set the objects velocity to a new direction which is (0,0), so no direction and no speed.
    }
}
