using UnityEngine;

public class ResourceButton : MonoBehaviour
{
    #region Fields

    [SerializeField] private GameState gameState;
    [SerializeField] private string resourceType;

    #endregion

    #region Public Methods

    public void OnClick()
    {
        gameState.UpdateResource(resourceType);
    }

    #endregion
}