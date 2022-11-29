using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //triggers object to be destroyed on collision
    private void OnTriggerEnter(Collider other) 
    {
        //if collision with player game over, else destroy animal/object
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over!"); //logs Game Over to console
            Destroy(other.gameObject); // destroys player
        }
        else
        {
            Destroy(gameObject); //destroys thrown object
            Destroy(other.gameObject); //destroys animal
        }
    }
}
