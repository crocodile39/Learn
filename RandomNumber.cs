using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    private int integerNumber = 0;
    private float floatNumber = 0;

    private float range = 10;
    // Start is called before the first frame update
    void Start()
    {
        //Setup to get a random number within a range: Random.Range(minimum number, maximum number)
        integerNumber = Random.Range(-10, 11);
        //This will set integerNumber to a integer between anywhere from -10 to 10
        //the maximum is EXCLUSIVE so it cant be that, minimum is INCLUSIVE so it can be that

        floatNumber = Random.Range(-10f, 10f);
        //Sets between -10 and 10 but can be a decimal because of the f after the number

        floatNumber = Random.Range(-range, range);
        //can use variables in place of number, so this does the same exact thing as the thing above
    }

   
}
