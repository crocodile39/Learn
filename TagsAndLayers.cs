using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagsAndLayers : MonoBehaviour
{
    //Tags and layers can be found under the name of the object in the inspector

    //TAGS
    //can create them by clicking tag -> add tag and type in a name for a new one
    //tags are just like a dog tag in real life
    //identify objects by a name
    //like player, enemy, or anything else
    //most often used in checking collisions

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Setup for checking what tag the object you hit has: if (collision.gameObject.CompareTag("name of tag you want to check"))
        //that returns a true of false bool. so if it is that tag it gives true, otherwise false
        if (collision.gameObject.CompareTag("Player"))
        {
            //this will happen if this hit a object with Player as its tag
        }
    }

    //LAYERS
    //alot like a tag but can effect physics
    //can set what layers can interact with eachother for collisions
        //edit -> project settings -> physics 2d --> scroll to collision matrix --> select which layers can hit eachother.
    //use when you dont want things to hit eachother, like you dont want the player colliding with itself, or bullets colliding with other bullets usually
}
