using TMPro;
using UnityEngine;

public class Money : MonoBehaviour
{
    [SerializeField] private TMP_Text _countOfMoney;
    [SerializeField] private Score _score;

    private void OnEnable()
    {
        _countOfMoney.text = _score.CountOfPointsOnLevel.ToString();
    }
}