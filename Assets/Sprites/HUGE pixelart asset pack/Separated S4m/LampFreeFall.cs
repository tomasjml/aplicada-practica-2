using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampFreeFall : MonoBehaviour
{
    Vector3 deltaPos = new Vector3();
    Vector3 currentSpeed = new Vector3();
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        // Yf = Y0 + V0y * T + (aT^2)/2
        deltaPos.y = currentSpeed.y * Time.deltaTime + Physics.gravity.y * Mathf.Pow(Time.deltaTime, 2) / 2;
        gameObject.transform.Translate(deltaPos);
        currentSpeed += Physics.gravity * Time.deltaTime;
    }
}
