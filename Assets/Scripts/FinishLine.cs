using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class FinishLine : MonoBehaviour
{
    public TimeCounter timeCounter;
    public GameObject restartPanel;
    private int position;
    public Collider2D finishCollider;

    // Start is called before the first frame update
    void Start()
    {
        position = 1;
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
            string text = ("Czas: " + timeCounter.GetTime() + Environment.NewLine + "Miejsce: " + position) ;
            GameObject.Find("CzasMiejsce").GetComponent<TextMeshProUGUI>().text = text;
            var audio = GameObject.Find("PlayerCar").GetComponent<AudioSource>();
            audio.pitch = 0.9f;
            audio.volume = 0.3f;
            finishCollider.enabled = false;
        }
        else
        {
            position++;
        }
    }


}
