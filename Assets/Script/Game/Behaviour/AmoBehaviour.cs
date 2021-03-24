using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmoBehaviour : MonoBehaviour
{
    Vector3 _currentSpeed = new Vector3();
    Vector3 _deltaPos = new Vector3();
    bool _shooted;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!_shooted)
            return;
        _deltaPos = _currentSpeed * Time.deltaTime + Physics.gravity * Mathf.Pow(Time.deltaTime, 2) / 2;
        gameObject.transform.Translate(_deltaPos);
        _currentSpeed += Physics.gravity * Time.deltaTime;
    }

    public void Shoot(Vector3 startingSpeed, float shootingAngle)
    {
        _currentSpeed = new Vector3(startingSpeed.x * Mathf.Cos(shootingAngle), startingSpeed.y * Mathf.Sin(shootingAngle));
        _shooted = true;
    }
}
