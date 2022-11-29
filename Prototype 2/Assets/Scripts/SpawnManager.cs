using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public variables
    public GameObject[] animalPrefabs; //array of game objects
    
    //private variables
    private float spawnRangeX = 20; //range limit for x-axis
    private float spawnPosZ = 20; //z-axis position for animal spawn
    private float startDelay = 2; //defines the delay until first calling of InvokeRepeating
    private float spawnInterval = 1.5f; //defines time between each subsequent calling of InvokeRepeating

    // Start is called before the first frame update
    void Start()
    {
        //repeatedly calls SpawnRandomAnimal method, starting at a set time, and repeating at another set time
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //when player presses S calls SpawnRandomAnimal method
    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //         SpawnRandomAnimal();
    //    } 
    }

    // spawn random animal from array in a random position and set to predefined orientation
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); //index for array, randomly chooses index number 
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); //random spawn position

        //spawns animals
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
