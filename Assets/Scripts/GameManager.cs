using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //private varaibles
    private int score = 0;
    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //lives method
    public void AddLives(int value)
    {
        //increases lives by value
        lives += value;
        //if lives equal to or less than 0 game over
        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        //logs amount of lives remaining
        Debug.Log("Lives = " + lives);
    }

    //score method
    public void AddScore(int value)
    {
        //increses score by value
        score += value;
        //logs score
        Debug.Log("Score = " + score);
    }
}
