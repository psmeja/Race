using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public TimeCounter timeCounter;
    public GameObject restartPanel;

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
        if (collision.name == "PlayerCar")
        {
            timeCounter.StopCounter();
            restartPanel.SetActive(true);
            GameObject.Find("PlayerCar").GetComponent<PlayerCar>().enabled = false;
            var audio = GameObject.Find("PlayerCar").GetComponent<AudioSource>();
            audio.pitch = 0.9f;
            audio.volume = 0.3f;
        }
    }


}
