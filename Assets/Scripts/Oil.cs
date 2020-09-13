using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            if (collision.GetComponent<PlayerCar>() != null)
                collision.GetComponent<PlayerCar>().speedFactor *= 0.5f;

            if (collision.GetComponent<AI_Car1>() != null)
                collision.GetComponent<AI_Car1>().speedFactor *= 0.5f;

        }


    }

    private void OnTriggerExit2D(Collider2D collision)         
    {
        if (collision.gameObject.tag == "Car")
        {
            if (collision.GetComponent<PlayerCar>() != null)
                collision.GetComponent<PlayerCar>().speedFactor *= 2f;

            if (collision.GetComponent<AI_Car1>() != null)
                collision.GetComponent<AI_Car1>().speedFactor *= 2f;
        }

    }
}
