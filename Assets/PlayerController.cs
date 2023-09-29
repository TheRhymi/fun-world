 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;

    float maxSpeed = 0.5f;
    bool isOnground = false;
    // Create a reference to the RigidBody2D so we can manipulate it
    Rigidbody2D playerObject;

    // Start is called before first frame update
    void Start()
    {
        // Find the RigidBody2D component that is attached to the same object as this script
        playerObject = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Create a 'float' that will equal to the players horizontal input
        float movementValueX = Input.GetAxis("Horizontal");
        

        //Change the X velocity of the RigidBody2D to be equal to the movement value
        playerObject.velocity = new Vector2(movementValueX * 5, playerObject.velocity.y);

        // Check to see if the ground check object is touching the ground
        isOnground = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);
        
    }
}
