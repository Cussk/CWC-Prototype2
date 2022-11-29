using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //private variables
    private float topBound = 30.0f; //variable for top boundary of game screen
    private float lowerBound = -10.0f; //variable for bottom boundary of game
    private float sideBound = 30.0f; //variable for side boundaries of game screen

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if object goes beyond boundary destroy object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
            {
                Debug.Log("Game Over!"); //logs to console game over when animal goes out of bounds
                Destroy(gameObject);
            }
        else if (transform.position.x > sideBound)
            {
                Debug.Log("Game Over!"); //logs to console game over when animal goes out of bounds
                Destroy(gameObject);
            }
        else if (transform.position.x < -sideBound)
            {
                Debug.Log("Game Over!"); //logs to console game over when animal goes out of bounds
                Destroy(gameObject);
            }
    }
}
