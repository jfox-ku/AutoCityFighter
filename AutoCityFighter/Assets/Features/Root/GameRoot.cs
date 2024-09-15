using System;
using System.Collections;
using System.Collections.Generic;
using Features;
using Features.Grid;
using Features.OrderedEvents;
using UnityEngine;
using Grid = Features.Grid.Grid;

public class GameRoot : MonoBehaviour
{
    public static GameRoot Instance { get; private set; }
    public GameRootData Data;
    public GameData GameData;
    
    private Grid _grid;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        // Initialize game
        GameData.Reset();
        _grid = new Grid();
        _grid.Initialize(Data.GridConfig);
        GameEvents.OnGameInitialized.Invoke();
        
        GameEvents.OnGameStart.Invoke();
    }

    [Serializable]
    public class GameRootData
    {
        public GridConfig GridConfig;
    }
}
