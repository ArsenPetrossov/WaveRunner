using UnityEngine;

public class DisplayManager : MonoBehaviour
{
    private const float MAP_X = 100.0f;
    private const float MAP_Y = 100.0f;

    private float _minX;
    private float _maxX;
    private float _minY;
    private float _maxY;

    private Vector2 _leftUp;
    private Vector2 _leftDown;
    private Vector2 _rightUp;
    private Vector2 _rightDown;

    private float _width;
    private float _height;

    private float _left;
    private float _right;
    private float _down;
    private float _up;

    private void Awake()
    {
        InitDisplayBound();
    }

    private void InitDisplayBound()
    {
        var vertExtent = Camera.main.orthographicSize;
        var horzExtent = vertExtent * Screen.width / Screen.height;


        _minX = horzExtent - MAP_X / 2.0f;
        _maxX = MAP_X / 2.0f - horzExtent;
        _minY = vertExtent - MAP_Y / 2.0f;
        _maxY = MAP_Y / 2.0f - vertExtent;

        _leftUp = new Vector2(_maxX - 50, _minY + 50);
        _leftDown = new Vector2(_maxX - 50, _maxY - 50);
        _rightUp = new Vector2(_minX + 50, _minY + 50);
        _rightDown = new Vector2(_minX + 50, _maxY - 50);

        _width = _rightDown.x - _leftDown.x;
        _height = _leftUp.y - _leftDown.y;

        _left = _leftUp.x;
        _right = _rightUp.x;
        _up = _leftUp.y;
        _down = _leftDown.y;
    }

    public float GetWidth()
    {
        return _width;
    }
}