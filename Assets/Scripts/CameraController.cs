using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed;
    public Vector3 offset;

    // Start is called before the first frame update

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position.normalized, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }


}
