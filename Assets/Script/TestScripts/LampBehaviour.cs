using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampBehaviour : MonoBehaviour
{
    Vector3 _deltaPos = new Vector3();
    Vector3 currentSpeed = new Vector3();
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x >= (gameObject.transform.position.x - 6f))
        {
            _deltaPos.y = currentSpeed.y * Time.deltaTime + Physics.gravity.y * Mathf.Pow(Time.deltaTime, 2) / 2;
            gameObject.transform.Translate(_deltaPos);
            currentSpeed.y += Physics.gravity.y * Time.deltaTime;
        }
    }
}
