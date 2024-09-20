using PathCreation.Examples;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private PathFollower _pathFollower;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private AudioClip _winSound;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private GameObject _winPanel;

    private void OnTriggerEnter(Collider other)
    {
        _winPanel.SetActive(true);
        _audioSource.PlayOneShot(_winSound);
        _pathFollower.enabled = false;
        _playerMovement.enabled = false;
    }
}
