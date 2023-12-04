using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : MonoBehaviour
{
    private float waitTime = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        //How to call a IEnumerator
        //Setup: StartCoroutine(NameOfIEnumerator());
        StartCoroutine(WaitSeconds());
    }

    // Update is called once per frame
    void Update()
    {
    }

    //Must put waits in a "IEnumerator"
    //setup: IEnumerator Name(){}
    IEnumerator WaitSeconds()
    {
        //setup to wait a amount of seconds: yield return new WaitForSeconds(number);
        yield return new WaitForSeconds(1);
        //will do this after that amount of time

        yield return new WaitForSeconds(waitTime);
        //can also use variables for the time
    }
}
