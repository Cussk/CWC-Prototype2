using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 40.0f; //speed of object in frames

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves object on z-axis
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
