using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationBehaviour : MonoBehaviour
{
    public GameObject Object1, Object2, Object3, Object4;
    Vector3 _startingPosition = new Vector3(0, 7.5f);
    float _nextTime;
    const float MIN_TIME = 0.3f, MAX_TIME = 1.5f, MIN_X = -9f, MAX_X = 9f;

    // Start is called before the first frame update
    void Start()
    {
        _nextTime = GetNextTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _nextTime)
        {
            _startingPosition.x = Random.Range(MIN_X, MAX_X);
            Instantiate(NextCube(), _startingPosition, Quaternion.identity);
            _nextTime = GetNextTime();

        }
    }

    float GetNextTime()
    {
        return Time.time + (Random.Range(MIN_TIME, MAX_TIME));
    }

    GameObject NextCube()
    {
        GameObject _result;
        switch (Random.Range(0, 4))
        {
            case 0:
                return Object1;
            case 1:
                return Object2;
            case 2:
                return Object3;
            default:
                return Object4;
        }
    }
}
