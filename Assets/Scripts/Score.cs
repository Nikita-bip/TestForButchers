using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private GameObject _loosePanel;

    public int CountOfPointsOnLevel = 0;
    public static int CountOfPoints;

    private void Update()
    {
        _scoreText.text = CountOfPointsOnLevel.ToString();

        if (CountOfPointsOnLevel < 0)
            _loosePanel.SetActive(true);
    }
}