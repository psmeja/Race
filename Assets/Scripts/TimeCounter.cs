using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{

    public TextMeshProUGUI UICounter;
    public bool isCounterActive = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCounter();
    }

    // Update is called once per frame
    void Update()
    {
        float timer = Time.timeSinceLevelLoad;
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        if(isCounterActive)
        {
            UICounter.text = $"{minutes.ToString("00")}:{seconds.ToString("00")}";
        }
    }


    public void StopCounter()
    {
        isCounterActive = false;
    }

    public void StartCounter()
    {
        isCounterActive = true;
    }
}
