using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    [SerializeField] private Score _score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Bonus>(out Bonus bonus))
        {
            _score.CountOfPoints++;
        }

        else if (other.TryGetComponent<Debuff>(out Debuff debuff))
        {
            _score.CountOfPoints--;
        }
    }
}
