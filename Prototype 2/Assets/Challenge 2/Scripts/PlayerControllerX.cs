using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float releaseRate = 0.5f; //time between dog releases
    private float nextRelease = 0.0f; //time for next release

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog AND delay until specified time before release dog again
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextRelease)
        {
            //button function delay
            nextRelease = Time.time + releaseRate;
            //spawn dog
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
