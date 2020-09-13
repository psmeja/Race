using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Car1 : MonoBehaviour
{

    public Transform targetNavPoint;
    public float speedFactor;
    public AITrack1 aiTrack1;
    public float rotationFactor;
    public int currentNavPointIndex;
    public GameObject NPPrefab;

    // Start is called before the first frame update
    void Start()
    {
        currentNavPointIndex = 0;
        targetNavPoint = aiTrack1.navPoints[currentNavPointIndex];
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toTarget = targetNavPoint.position - transform.position;
        float angle = Vector3.Angle(transform.up, toTarget);
        Vector3 cross = Vector3.Cross(transform.up, toTarget);
        if (cross.z < 0)
            angle = -angle;

        transform.Rotate(0f, 0f, angle * rotationFactor * Time.deltaTime);
        transform.Translate(0, speedFactor * Time.deltaTime, 0);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform == targetNavPoint)
        {
            targetNavPoint = aiTrack1.GetNextNavPoint(ref currentNavPointIndex);

            Vector2 randomizePosition = (Vector2) targetNavPoint.position + Random.insideUnitCircle;

            GameObject randomizedNavPoint = Instantiate(NPPrefab);
            randomizedNavPoint.transform.position = randomizePosition;
            targetNavPoint = randomizedNavPoint.transform;
            Destroy(randomizedNavPoint, 120);
        }
    }

}
