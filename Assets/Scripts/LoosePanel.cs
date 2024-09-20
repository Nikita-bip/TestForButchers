using PathCreation.Examples;
using UnityEngine;

public class LoosePanel : MonoBehaviour
{
    [SerializeField] private PathFollower _pathFollower;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private AudioClip _looseSound;
    [SerializeField] private AudioSource _audioSource;

    private void OnEnable()
    {
        _audioSource.PlayOneShot(_looseSound);
        _pathFollower.enabled = false;
        _playerMovement.enabled = false;
    }
}