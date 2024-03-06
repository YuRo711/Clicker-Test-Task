using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameState : ScriptableObject
{
    #region Fields

    // If we're planning to add multiple resources, this could be useful
    private readonly Dictionary<string, int> _gameResources = new ()
    {
        {"gold", 0},
        {"silver", 0},
    };

    #endregion

    #region Public Methods

    public void UpdateResource(string resourceName, int resourceDelta = 1)
    {
        if (_gameResources.ContainsKey(resourceName))
        {
            _gameResources[resourceName] += resourceDelta;
        }
        else
        {
            throw new ArgumentException($"Invalid button resource name: {resourceName}");
        }
    }

    public int GetResource(string resourceName)
    {
        if (_gameResources.TryGetValue(resourceName, out var value))
        {
            return value;
        }
        else
        {
            throw new ArgumentException($"Invalid text field resource name: {resourceName}");
        }
    }

    public int GetTotalResources()
    {
        return _gameResources
            .Select((pair) => pair.Value)
            .Sum();
    }

    #endregion
}
