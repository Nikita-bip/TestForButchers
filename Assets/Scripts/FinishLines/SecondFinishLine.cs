using DG.Tweening;
using PathCreation.Examples;
using UnityEngine;

public class SecondFinishLine : MonoBehaviour
{
    [SerializeField] private GameObject[] _doors;
    [SerializeField] private AudioClip _finishSound;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Score _score;
    [SerializeField] private PathFollower _pathFollower;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private AudioClip _winSound;
    [SerializeField] private GameObject _winPanel;

    private float rotationDuration = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (_score.CountOfPointsOnLevel > 10)
        {
            foreach (var door in _doors)
            {
                _audioSource.PlayOneShot(_finishSound);
                door.transform.DORotate(new Vector3(0, -265, 0), rotationDuration, RotateMode.LocalAxisAdd);
            }
        }
        else
        {
            _score.CountOfPointsOnLevel = _score.CountOfPointsOnLevel * 2;
            _winPanel.SetActive(true);
            _audioSource.PlayOneShot(_winSound);
            _pathFollower.enabled = false;
            _playerMovement.enabled = false;
        }
    }
}