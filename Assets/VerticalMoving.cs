using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class VerticalMoving : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float _speed;
    [SerializeField] private float  _verticalMagnitude;
    
    private Vector3 _startState;
    private Vector3 _endState;
    private float _currentTime;

    void Start()
    {
        _startState = new Vector3(transform.position.x,-_verticalMagnitude, transform.position.z);
        _endState = new Vector3(transform.position.x,_verticalMagnitude, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;

        float progress = Mathf.PingPong(_currentTime, _speed) / _speed;
        transform.position = Vector3.Lerp(_startState, _endState, progress);

       
    }
}
