using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    [SerializeField] Button button;
    void Start()
    {
        button = GetComponent<Button>();
    }
    void PressedButton()
    {
        button.interactable = false;
    }
}
