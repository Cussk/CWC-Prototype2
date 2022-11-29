using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public variables
    public GameObject projectilePrefab; //allows object to be assigned to player
    public Transform projectileSpawnPoint; //changes spawnpoint of projectile

    //private variables
    private float verticalInput;
    private float horizontalInput;
    private float speed = 10.0f; //player speed in frames
    private float xRange = 20.0f; //range boundary x-axis
    private float zRangeMin = 0.0f; //min range boundary z-axis
    private float zRangeMax = 16.0f; //max range boundary z-axis

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //boundary at range on x-axis, if try to go below or above, keeps player at range limit
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //boundary at range on z-axis, if try to go below or above, keeps player at range limit
        if (transform.position.z < zRangeMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMin);
        }

        if (transform.position.z > zRangeMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMax);
        }

        //input for player left/right movement
        horizontalInput = Input.GetAxis("Horizontal");

        //player movement on x-axis
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //input for player up/down movement
        verticalInput = Input.GetAxis("Vertical");

        //player movement on z-axis
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        //Launches projectile from player on key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //spawns prefab object at player position facing predefined direction 
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }
    }
}
