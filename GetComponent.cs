using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    //GET COMPONENT IS A GOOD WAY TO SET A VALUE TO SPECIAL TYPES OF VARIABLES AND ACTUALLY CAHNGE OBJECTS IN GAME
        //Ex: A Transform, A Rigibody


    private Rigidbody2D rb;
    private Transform thisTrans;

    public GameObject otherObject;
    private Transform otherTrans;

    // Start is called before the first frame update
    void Start()
    {
        //often will get a rigidbody in the start method so you dont have to set it in unity
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GettingComponents()
    {
        //Setup: variable = GetComponent<Variable Type>();

        rb = GetComponent<Rigidbody2D>();
        //This will get this objects Rigidbody2D and set rb = to it

        thisTrans = GetComponent<Transform>();
        //This will get this objects Transfrom
            //However for transform you can do it like this:
            thisTrans = transform;
            //But this is pretty much just for this and gameobject


        //Can get things from other objects too
        //Setup: variable = gameobjectVariable.GetComponent<Variable Type>();

        otherTrans = otherObject.GetComponent<Transform>();
        //Will get whatever Transform of whatever object otherObject is and set otherTrans to it
    }

    void UsingPartsOfComponents()
    {
        //Since these variables like the transfrom isnt very useful by themselves can get parts of them
        //Can check what are the parts of them inside of unity if you go to a object and go to a component like transform you will see: position, rotation and scale

        //setup: variable.component

        Vector2 thisVelocity = rb.velocity;
        //So this is a local variable that is a vector(x,y), and you can set it to the rigibody velocity which is also a vector.

        rb.velocity = new Vector2(0, 1);
        //Can also change the unity components of objects in the game as if its a variable
        //So we get the rigidbodys velocity and change it to this vector we chose

        thisTrans.position = otherTrans.position;
        //again this doesnt change a variable we have, but instead changes a actual component of a object in game
        //in this case we use this objects transfrom and get its position, then set this objects position to that of the other objects position
        //pretty much teleporting this object to that objects position
    }
}
