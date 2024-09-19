using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    public int CountOfPoints = 0;

    private void Update()
    {
        _scoreText.text = CountOfPoints.ToString();

        if (CountOfPoints < 0)
            CountOfPoints = 0;
    }
}
