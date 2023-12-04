using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Variables are declared as: protectionLevel type name = value;
        //Protection Levels: public, private, protected
            //public = can see & change it in unity, and can check it from other scripts
            //private = cant see or change in unity, cant check from other scripts
            //protected = can be accessed in classes that inherit from that script. NOT IMPORTANT
        //Main Types: int, float, string, bool
            //int = whole number
            //float = whole/decimal number
            //string =  text
            //bool = true/false
        //Name: can be anything
            //doesnt start with a number
            //no special characters
            //no spaces
            //Cannot be a name you used already
            //SHOULD have meaning
            //SHOULD be in camelCase = first word is lowercase, every word after starts with uppercase
                //ex: bulletSpeed
        //Value: must match the type
            //string must = something in "quotes"
            //bool = true or false
            //float = number that can be a decimal, if decimal put f after it

        //Examples

        private bool isDead = false;
        //Can't be accessed in unity or other scripts, is a true of false, named isDead with camelCase, = false

        public int livesLeft = 10;
        //Can be accessed in unity and other scripts, is a whole number, named livesLeft, = 10

        public float health = 100;
        //Can be accessed in unity and other scripts, either whole or decimal number, named health(one word so no capitalization), = 100, no f needed since whole number

        private string playerName = "Andrew";
        //Cant be accessed in unity or other scripts, is words/ a word/ a letter, named playerName, = Andrew and has quotes since its words/letters

        private bool isFalling;
        //Since it has no value set it goes to its default value.
            //Default Values - Bool = false, int = 0, float = 0, string = ""


    //Unity variables types
        //Vector2, Vector3 - holds a coordinate 2 is (x,y), 3 is (x,y,z)
        //Gameobject - object in the game or in your files
        //Transfrom - the transfrom component that is on a gameobject
        //Rigidbody2d, Rigidbody - the physics on a gameobject(either 2d or 3d)

        //Examples

        private Vector2 playerSpawnPosition = new Vector2(0,0);
        //When giving a value to a vector2 or vector3 it must be declared as a new vector2/3(put coordinate in here)

        private GameObject player;
        private Transform trans;
        private Rigidbody2D rb;
        //can't immidiately set a value to things that are found in the game.

    //Arrays
        //Putting [] after the type means the variable can hold multiple values
        //Arrays cannot change size, so if an array holds 5 values at the start of the game it can never have more or less
        //If setting value in script it should = {values go in here, seperated by commas}

        //Examples

        private int[] itemStrength = {2,5,1,3};
        //This is an array of whole numbers. Holds four numbers, the numbers can be changed, but the size of the array can't.

        public GameObject enemies;
        //This is an array with no size, so it wouldn't help. But since its public it can be changed in unity where the size and its contents can be defined there.




    // Start is called before the first frame update
    void Start()
    {
        //How to actually use variables
            //Reassigning values (changing the value directly to another)
            livesLeft = 1;
            //Just write the variable name and then = the new value. The new value must still be of that variables type, a int cant be reassigned to a string

            //Modifying values
            livesLeft += 2;
            //This will add two to what livesleft is. so if livesleft is 1, then this is 1+2, which is 3. Can put any operator(+, -, *, /) instead of the plus.

            //Changing arrays
            itemStrength[2] = 100;
        //variable name followed by brackets[] with the position of the value you want to change.(positions start at 0), so the zeroith number in the array is 2.
        //This changes the 3rd number in that array which was 1, and changes it to 100.



        //THOSE ARE ALL GLOBAL VARIABLES
        //Global variables are those created outside of any curly brackets other than the ones around the whole script

        //local variables are ones made inside a set of curly brackets, and they can't be used anywhere outside those curly brackets
        //like this
        int localInteger = 100;
        //No need for protection level for local variables

        livesLeft = localInteger;
        //Can use them just like normal variables

    }
}
