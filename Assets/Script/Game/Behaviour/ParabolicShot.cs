using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolicShoot : MonoBehaviour
{
    Vector3 startingSpeed;
    const float SCALAR_SPEED = 20f;
    float currentAngle, deltaY, deltaX;
    Vector3 userInput = new Vector3();
    public GameObject Amunition;
    // Start is called before the first frame update
    void Start()
    {
        startingSpeed = new Vector3(SCALAR_SPEED, SCALAR_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ? (Vector3)Input.GetTouch(0).position : Input.mousePosition);
        deltaY = userInput.y - gameObject.transform.position.y;
        deltaX = userInput.x - gameObject.transform.position.x;

        currentAngle = Mathf.Atan(deltaY / deltaX);
        Debug.Log(currentAngle * Mathf.Rad2Deg);

        // Trigger:
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Amunition, gameObject.transform.position, Quaternion.identity).GetComponent<AmoBehaviour>().Shoot(startingSpeed, currentAngle);
        }
    }
}
