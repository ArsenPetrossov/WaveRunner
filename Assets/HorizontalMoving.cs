using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class HorizontalMoving : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float  _horizontalMagnitude;
    
    private Vector3 _startState;
    private Vector3 _endState;
    private float _currentTime;

    void Start()
    {
        _startState = new Vector3(-_horizontalMagnitude, transform.position.y, transform.position.z);
        _endState = new Vector3(_horizontalMagnitude, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;

        float progress = Mathf.PingPong(_currentTime, _speed) / _speed;
        transform.position = Vector3.Lerp(_startState, _endState, progress);

       
    }
}