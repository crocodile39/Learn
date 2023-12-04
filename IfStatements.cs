using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    private int health = 100;
    private bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If Statment setup: if(question that can be either true or false) {action that will happen if that question is true}

        //Can have many different comparisons

        //all these do pretty much same thing

        //health equals 0
        if(health == 0)
        {
            dead = true;
        }
        //health is less than 1
        if(health < 1)
        {
            dead = true;
        }
        //health less than or equal to 0
        if(health <= 0)
        {
            dead = true;
        }

        //These also do similiar things

        //health doesnt equal 0
        if(health != 0)
        {
            dead = false;
        }
        //health more than 0
        if(health > 0)
        {
            dead = false;
        }
        //health more than or equal to 1
        if(health >= 1)
        {
            dead = false;
        }




        //Than you can make a statment right after to say if this statement is false, then do this

        if(health <= 0)
        {
            dead = true;
        }
        //Pretty much if health isnt less than or equal to 0 then set dead to false
        //setup is just else{}
        else
        {
            dead = false;
        }


        //Can also make chains of if else that will only run if the last thing was false
        if(health < 0)
        {
            dead = true;
        }
        //means that the thing above this must be false to do this
        else if(health == 0)
        {
            dead = true;
        }
        else
        {
            dead = false;
        }


    }
}
