using System;
using System.Collections.Generic;
using UnityEngine;

namespace Features.Grid
{
    [Serializable]
    public class GridConfig
    {
        public Vector2Int OwnedOnStartSize;
        public Vector2Int MaxSize;
        public OwnedGridList BaseOwnedGrid;
    }
    
    [Serializable]
    public class OwnedGridList : List<List<bool>>
    {
        
        public bool IsOwned(int x, int y)
        {
            return this[x][y];
        }
        
        public void SetOwned(int x, int y, bool value)
        {
            this[x][y] = value;
        }
    }
}