using System;
using TMPro;
using UnityEngine;

public class ResourceNumber : MonoBehaviour
{
    #region Fields

    [SerializeField] private GameState gameState;
    [SerializeField] private string resourceType;
    [SerializeField] private TMP_Text textField;

    #endregion

    #region MonoBehaviour Callbacks

    private void Update()
    {
        textField.text = gameState.GetResource(resourceType).ToString();
    }

    #endregion
}