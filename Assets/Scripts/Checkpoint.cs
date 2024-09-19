using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] private GameObject[] _flags;

    private float rotationDuration = 1.0f;

    private void OnTriggerEnter(Collider other)
    {
        foreach (var flag in _flags)
        {
            flag.transform.DORotate(new Vector3(0, 0, -90), rotationDuration, RotateMode.LocalAxisAdd);
        }
    }
}
