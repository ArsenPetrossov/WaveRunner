using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] 
    private GameObject _player;
    [SerializeField] 
    private float _smoothTime = 0.3F;
    [SerializeField] 
    private int _yOffset;

    private Vector3 _velocity;

    private void Update()
    {
        var targetPosition = _player.transform.TransformPoint(new Vector3(0, _yOffset, -10));
        targetPosition = new Vector3(0, targetPosition.y, targetPosition.z);

        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _velocity, _smoothTime);
    }
}