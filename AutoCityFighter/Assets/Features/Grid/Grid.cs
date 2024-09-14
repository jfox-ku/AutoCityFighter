using System;
using System.Collections.Generic;
using UnityEngine;

namespace Features.Grid
{
    public interface IGridElement
    {
        Vector2Int Position { get; set; }
    }

    [Serializable]
    public class Grid
    {
        // Use this for serialization
        [SerializeField] 
        private List<TileData> _tileDataList = new List<TileData>();

        // Non-serialized dictionary for runtime use
        [NonSerialized]
        public Dictionary<Vector2Int, Tile> Tiles = new Dictionary<Vector2Int, Tile>();

        public void Initialize(Vector2Int size)
        {
            for (int x = 0; x < size.x; x++)
            {
                for (int y = 0; y < size.y; y++)
                {
                    var tile = new Tile {Position = new Vector2Int(x, y)};
                    Tiles.Add(tile.Position, tile);
                    if (x % 2 == 0)
                    {
                        tile.AddComponent(new OccupiedTileFlagComponent());
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