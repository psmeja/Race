using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : MonoBehaviour
{
    Transform carTransform;
    public float speedFactor;
    public float rotateSpeedFactor;
    AudioSource audioSource;
    float audioPitchDefault = 0.8f;
    float audioPitchAcceleration = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        carTransform = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var verticalAxisInput = Input.GetAxis("Vertical");
        var horizontalAxisInput = Input.GetAxis("Horizontal");

        carTransform.Translate(0, verticalAxisInput * speedFactor * Time.deltaTime, 0);
        carTransform.Rotate(0, 0, horizontalAxisInput * (-rotateSpeedFactor) * speedFactor * Time.deltaTime);
        audioSource.pitch = (audioPitchDefault + Mathf.Abs((audioPitchAcceleration * verticalAxisInput)));
    }
}
