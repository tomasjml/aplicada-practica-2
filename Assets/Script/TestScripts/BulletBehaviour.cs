using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    GameObject centerObject;
    Vector3 currentPosition = new Vector3(), angle, currentSpeed = new Vector3();
    float currentDistance, scalarAcceleration = 5f, shootingTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        angle = currentSpeed * (Time.time * shootingTime) / currentDistance;

        currentPosition.x = centerObject.transform.position.x + currentDistance * Mathf.Cos(angle.x);
        currentPosition.y = centerObject.transform.position.y + currentDistance * Mathf.Sin(angle.y);

        gameObject.transform.position = currentPosition;

        currentSpeed.x += scalarAcceleration * Time.deltaTime;
        currentSpeed.y += scalarAcceleration * Time.deltaTime;
    }

    public void Shoot(GameObject center, float bulletDistance)
    {
        centerObject = center;
        currentDistance = bulletDistance;
        shootingTime = Time.time;
    }
}
