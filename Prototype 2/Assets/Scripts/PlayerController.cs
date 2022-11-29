using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f; //player speed in frames
    public float xRange = 20.0f; //range boundary x-axis

    public GameObject projectilePrefab; //allows object to be assigned to player

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

        //input for player left/right movement
        horizontalInput = Input.GetAxis("Horizontal");

        //player movement on x-axis
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Launches projectile from player on key press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //spawns prefab object at player position facing predefined direction 
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
