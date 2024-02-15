using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChainging : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _size;
    

    
    private Vector3 _startState;
    private Vector3 _endState;
    private float _currentTime;

    void Start()
    {
        _startState = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        _endState = new Vector3(transform.localScale.x + _size, transform.localScale.y + _size, transform.localScale.z);
    }


    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;

        float progress = Mathf.PingPong(_currentTime, _speed) / _speed;
        transform.localScale = Vector3.Lerp(_startState, _endState, progress);
    }
}
