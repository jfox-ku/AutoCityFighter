using System;
using UnityEngine;

namespace Features.Grid
{
    [Serializable]
    public class TileData
    {
        public Vector2Int Position;
        public Tile Tile;

        public TileData(Vector2Int position, Tile tile)
        {
            Position = position;
            Tile = tile;
        }
    }
}