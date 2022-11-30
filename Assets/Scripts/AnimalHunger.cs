using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    //public variables
    public Slider hungerSlider; //slider for hunger gauge
    public int amountToBeFed; //number needed to be fed

    //private variables
    private int currentFedAmount = 0; //number of times fed
    private GameManager gameManager; //imports GameManager methods

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed; //max value of slider equals number of times needed to be fed
        hungerSlider.value = 0; //slider starts at 0
        hungerSlider.fillRect.gameObject.SetActive(false); //slider not active before first frame update

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //calls  game manager methods on game start
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //feed animal method updates current fed amount
    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount; //current fed is equal to its current amount plus amount added
        hungerSlider.fillRect.gameObject.SetActive(true); //activates slider after first time frame updates
        hungerSlider.value = currentFedAmount; //slider value equals current fed amount

        //if current amount fed is greater or equal to amount needed to be fed, add score and destroy animal
        if(currentFedAmount >= amountToBeFed)
        {
            gameManager.AddScore(amountToBeFed); //add score based on animal feed count
            Destroy(gameObject, 0.1f); //destroy object after 0.1 frame delay
        }

    }
}
