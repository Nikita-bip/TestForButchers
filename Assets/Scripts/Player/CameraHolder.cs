using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private Vector3 _initRotation;

    private void Awake()
    {
        _initRotation = transform.eulerAngles;
    }

    private void Update()
    {
        transform.position = new Vector3(_player.position.x, _player.position.y, _player.position.z);
        transform.eulerAngles = new Vector3(_player.eulerAngles.x + _initRotation.x, _player.eulerAngles.y + _initRotation.y, 0);
    }
}
