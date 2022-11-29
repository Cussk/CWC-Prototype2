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
        Destroy(gameObject); //destroys thrown object
        Destroy(other.gameObject); //destroys animal
    }
}
