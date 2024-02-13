using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance;
    private float _hueValue;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _hueValue = Random.Range(0, 10) / 10.0f;

        ChangeBackgroundColor();
    }

    public void ChangeBackgroundColor()
    {
        _hueValue += 0.1f;
        if (_hueValue >= 1)
        {
            _hueValue = 0;
        }

        Camera.main.backgroundColor = Color.HSVToRGB(_hueValue, 0.6f, 0.8f);
    }
}