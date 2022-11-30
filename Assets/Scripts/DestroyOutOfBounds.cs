using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //private variables
    private float topBound = 30.0f; //variable for top boundary of game screen
    private float lowerBound = -10.0f; //variable for bottom boundary of game
    private float sideBound = 30.0f; //variable for side boundaries of game screen
    private GameManager gameManager; //imports GameManager script methods

    // Start is called before the first frame update
    void Start()
    {
        //calls the game manager script on game start
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
                gameManager.AddLives(-1); //removes 1 life when animal goes out of bounds
                Destroy(gameObject); //destroys animal
            }
        else if (transform.position.x > sideBound)
            {
                gameManager.AddLives(-1); //removes 1 life when animal goes out of bounds
                Destroy(gameObject); //destroys animal
            }
        else if (transform.position.x < -sideBound)
            {
                gameManager.AddLives(-1); //removes 1 life when animal goes out of bounds
                Destroy(gameObject); //destroys animal
            }
    }
}
