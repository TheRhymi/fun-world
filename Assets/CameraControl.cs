using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Create a public reference to the player.  We will be able to assign this with the Unity editor.
    public GameObject player;

    // Update is called once per frame
    
    void Update()
    {
        //change our position relative to player position
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        
    }
}
