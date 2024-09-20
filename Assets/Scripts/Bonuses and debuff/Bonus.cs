using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private AudioClip _pickupSound;
    [SerializeField] private AudioSource _audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            _audioSource.PlayOneShot(_pickupSound);
            Destroy(this.gameObject);
        }
    }
}
