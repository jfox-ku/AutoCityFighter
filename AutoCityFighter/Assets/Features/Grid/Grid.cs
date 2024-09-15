using System;
using System.Collections.Generic;
using UnityEngine;

namespace Features.Grid
{
    [Serializable]
    public class Grid
    {
        private GridConfig _config;
        // Use this for serialization
        [SerializeField] 
        private List<TileData> _tileDataList = new List<TileData>();

        // Non-serialized dictionary for runtime use
        [NonSerialized]
        public Dictionary<Vector2Int, Tile> Tiles = new Dictionary<Vector2Int, Tile>();

        public void Initialize(GridConfig config)
        {
            for (int x = 0; x < config.MaxSize.x; x++)
            {
                for (int y = 0; y < config.MaxSize.y; y++)
                {
                    var tile = new Tile {};
                    var positionComp = new TilePositionComponent()
                    {
                        Position = new Vector2Int(x, y)
                    };
                    tile.AddComponent(positionComp);
                    Tiles.Add(positionComp.Position, tile);
                    if (x % 2 == 0)
                    {
                        tile.AddComponent(new TileOwnedFlagComponent());
                    }
                }
            }
        }
        
        // Convert dictionary to list before serialization
        public void PrepareForSerialization()
        {
            _tileDataList.Clear();
            foreach (var tile in Tiles)
            {
                _tileDataList.Add(new TileData(tile.Key, tile.Value));
            }
        }

        // Convert list back to dictionary after deserialization
        public void OnAfterDeserialization()
        {
            Tiles.Clear();
            foreach (var tileData in _tileDataList)
            {
                Tiles.Add(tileData.Position, tileData.Tile);
            }
        }
        
//         // Serialize grid
//         var grid = new Grid();
//         grid.Initialize(new Vector2Int(10, 10));
//         grid.PrepareForSerialization();
//         string json = JsonUtility.ToJson(grid);
//
// // Deserialize grid
//         Grid deserializedGrid = JsonUtility.FromJson<Grid>(json);
//         deserializedGrid.OnAfterDeserialization();
        
    }
}