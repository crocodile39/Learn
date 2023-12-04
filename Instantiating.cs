using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiating : MonoBehaviour
{
    //Will almost always have a gameobject variable that you will set in the inspector by creating a prefab then dragging it to this variable in the inspector
    public GameObject objectToCreate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        //Instatiating is how to create a object
        //Setup: Instantiate(gameobject variable, a position(aka a vector), a rotation(pretty much always Quaternion.identity which is just whatever its roation is already))
        Instantiate(objectToCreate, transform.position, Quaternion.identity);
    }
}
