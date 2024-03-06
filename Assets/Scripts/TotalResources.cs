using System;
using TMPro;
using UnityEngine;

public class TotalResources : MonoBehaviour
{
    #region Fields

    [SerializeField] private GameState gameState;
    [SerializeField] private TMP_Text textField;

    #endregion

    #region MonoBehaviour Callbacks

    private void Update()
    {
        textField.text = gameState.GetTotalResources().ToString();
    }

    #endregion
}