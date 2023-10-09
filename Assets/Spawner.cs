 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawner : MonoBehaviour
{
    //Create a public array of objects to spawn, we will fill this up using Unity Editor
    public GameObject[] objectToSpawn;

    float timeToNextSpawn;             //Tracks how long we should wait before next object will spawn
    float timeSinceLastSpawn = 0.0f;   //Tracks time since we last spawned something

    public float minSpawnTime = 0.5f;  //Minimum time before spawning each object
    public float maxSpawnTime = 3.0f;  //Maximum time before spawning each object

    //Start is called before first frame update
    void Start()
    {
        //Random.Range returns a random float between two values
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        //Add Time.Deltatime returns the orignal amount of time passed since last frame
        //This will create a float that counts up in seconds
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

       //If we've counted past the time we have to wait..
        if (timeSinceLastSpawn > minSpawnTime )
        {
            //Use Random.Range to pick a number between 0 and the amount of items we'll have on our object list
            int selection = Random.Range(0, objectToSpawn.Length);

            //Instantiate spawns a GameObject - in this case we tell it to spawn a GameObject from our objectToSpawn list
            //The second parameter in the brackets tells it where to spawn, so we've entered the position of the spawner
            //The third parameter is for rotation, and Quaternion.identity means no rotation

            Instantiate(objectToSpawn[selection], transform.position, Quaternion.identity);

            //After spawning, we select a new random time for the next object to spawn and set our timer back to zero
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;


        }
    }
}
