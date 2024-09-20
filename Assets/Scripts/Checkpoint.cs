using UnityEngine;
using DG.Tweening;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private GameObject[] _flags;
    [SerializeField] private AudioClip _checkpointSound;
    [SerializeField] private AudioSource _audioSource;

    private float rotationDuration = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        foreach (var flag in _flags)
        {
            _audioSource.PlayOneShot(_checkpointSound);
            flag.transform.DORotate(new Vector3(0, 0, -90), rotationDuration, RotateMode.LocalAxisAdd);
        }
    }
}
