using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Much like the Start() and update() methods, OnTriggerEnter2D is a special Unity method that is called
    //by Unity automatically at a specific point. in this case, when something enters the Trigger, attatched to
    //this game object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if the game object touches the trigger, is tagged with cleanup
        if (collision.gameObject.tag == "CleanUp") 
        {
            //then we use this method to destroy it
            Destroy(collision.gameObject);
        }
    }
   
}
