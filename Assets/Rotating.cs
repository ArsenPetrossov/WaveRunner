using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Rotating : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Quaternion _startState;
    private Quaternion _endState;
    private float _currentTime;

    void Start()
    {
        _startState = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
        _endState = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, 180f);
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;

        float progress = Mathf.PingPong(_currentTime, _speed) / _speed;
        transform.rotation = Quaternion.Lerp(_startState, _endState, progress);
    }
}