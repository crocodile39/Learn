using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check inside of a if statement
        //Two ways of checking input
            //Keycode
            //Button
        //For each of those 3 different types of checks
            //Down
            //Held
            //Up

        //Keycode
        //setup: if(Input.GetKey(Down,nothing,Up)(KeyCode.Letter))
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Do this the frame E is first pressed down
        }
        if (Input.GetKey(KeyCode.E))
        {
            //Do this the all frames E is pressed down
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            //Do this the frame E is no longer pressed
        }

        //Button
        //Have to go to top of screen on unity: edit -> project setting -> Input manager
            //here you can make names stand for buttons or other types of inputs
        //setup:Input.GetButton(Down,nothing,Up)("name of input"))
        if (Input.GetButtonDown("Shoot"))
        {
            //Do this the frame whatever "Shoot" stands for is first pressed
        }
        if (Input.GetButton("Shoot"))
        {
            //Do this all frames whatever "Shoot" stands for is first pressed
        }
        if (Input.GetButtonUp("Shoot"))
        {
            //Do this the frame whatever "Shoot" stands for is no longer pressed
        }

    }
}
