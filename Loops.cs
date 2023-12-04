using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    //Loops are used to do something multiple times, or until something stops the loop.

    private int number = 0;


    //Very useful for arrays, even a specific type of loop for arrays
    private int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,};



    // Start is called before the first frame update
    void Start()
    {
        WhileLoop();
        ForLoop();
        ForEachLoop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    
    void WhileLoop()
    {
        //While Loops setup like: while(what it will check whether to keep going){what it will do everytime that check is true}
        //Pretty much a if statement that will keep on going until its false
        while(number < 10)
        {
            number += 1;
        }
        //So this while loop will add one to number until number it = 10;
    }

    void ForLoop()
    {
        //For loops are set up like this: for(local variable that is almost always int i = 0, what it will check for just like a while loop, what will happen every time this runs)
        for(int i = 0; i < 10; i++)
        {
            number += 1;
        }
        //So this for loop will add 1 to number a total of 10 times.
    }

    void ForEachLoop()
    {
        //foreach loops are set up like this: foreach(variable type that matches the type of the array, new variable name, "in", name of the variable that is an array)
        foreach(int num in array)
        {
            number += num;
        }
        //So this foreach loop will add to number each value in the array

    }

}
