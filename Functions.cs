using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    private int test = 1;


    //This is a unity function. Something they already give you thats already called somewhere
    void Start()
    {
        
    }

    //This is a unity function. Something they already give you thats already called somewhere
    void Update()
    {
        //this is how you call a function just name();
        //This will perform whatever is in the function, and since this one returns void, it actually just performs a task and nothing more
        ReturnsNothing();
        //This one sets test to = 2

        //This function returns a integer, and since it returns 1+1, it pretty much makes ReturnsTwo() = 2, so it could be rewritten as test = 2;
        test = ReturnsTwo();

        //This function returns nothing, but requests we put in a integer, so we must.
        ChangesTest(2);
       
    }



    //Usually put your functins at the bottom

    //Functions are set up like this
    //ReturnType, Name()
    //{
    //
    //}
    //A return type just means that whatever calls this will get that back.

    //This one has a return type of void, which just means whatever calls this function will get nothing back from it
    void ReturnsNothing()
    {
        test = 2;
    }

    //This one has a return type of int, which just means that wherever this is called, it will get that value back in place of this function when this code reaches a return statement
    int ReturnsTwo()
    {
        return 1 + 1;
        //return means give back, so you have to put a value there that matches the return type
        //if a function reaches a return statement it wont perform anything written after that
        test = 100000;
        //So this will never be reached, so test won't change to 100000
    }


    //In addition functions can "request" values to be able to do whatever they are trying to do
    //This is done by putting a local variable in parentheses
    //Now when this function is called they can put whatever integer into the parentheses for the function to use
    void ChangesTest(int multiplier)
    {
        test = 2 * multiplier;
        //This will set test to 2 times whatever number they input when calling the functions
        //So if they give this function 2, test will = 4, if they give it 1, it will equal 2
    }
}
