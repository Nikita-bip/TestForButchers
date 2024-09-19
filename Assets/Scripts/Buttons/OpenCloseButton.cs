using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseButton : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _button;

    public void OpenPanel()
    {
        _panel.SetActive(true);
        _button.SetActive(false);
    }

    public void ClosePanel ()
    {
        _panel.SetActive(false);
        _button.SetActive(true);
    }
}
