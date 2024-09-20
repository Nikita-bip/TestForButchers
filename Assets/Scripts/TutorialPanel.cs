using PathCreation.Examples;
using UnityEngine;

public class TutorialPanel : MonoBehaviour
{
    [SerializeField] private PathFollower _pathFollower;
    [SerializeField] private PlayerMovement _playerMovement;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnEnable()
    {
        _pathFollower.enabled = false;
        _playerMovement.enabled = false;
    }

    private void OnDestroy()
    {
        _pathFollower.enabled = true;
        _playerMovement.enabled = true;
    }
}