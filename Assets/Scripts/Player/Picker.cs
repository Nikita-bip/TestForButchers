using UnityEngine;

public class Picker : MonoBehaviour
{
    [SerializeField] private Score _score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Bonus>(out Bonus bonus))
        {
            _score.CountOfPointsOnLevel +=2;
        }

        else if (other.TryGetComponent<Debuff>(out Debuff debuff))
        {
            _score.CountOfPointsOnLevel -= 2;
        }

        else if (other.TryGetComponent<GoodDoor>(out GoodDoor goodDoor))
        {
            _score.CountOfPointsOnLevel += 20;
        }

        else if (other.TryGetComponent<BadDoor>(out BadDoor badDoor))
        {
            _score.CountOfPointsOnLevel -= 20;
        }
    }
}