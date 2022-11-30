using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    //private variables
    private GameManager gameManager; //imports game manager methods

    // Start is called before the first frame update
    void Start()
    {
        //calls the game manager script on game start
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //triggers object to be destroyed on collision
    private void OnTriggerEnter(Collider other) 
    {
        //if collision with player lose 1 life and destroy animal, else destroy projectile
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject); // destroys animal
        }
        else if (other.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1); //calls AnimalHunger script and adds 1 to FeedAnimal method amount
            Destroy(gameObject); //destroys projectile
        }
    }
}
