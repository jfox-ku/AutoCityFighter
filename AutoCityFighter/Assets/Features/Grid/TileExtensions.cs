using UnityEngine;

namespace Features.Grid
{
    public static class TileExtensions
    {
        public static OccupiedTileFlagComponent GetOccupiedTileFlagComponent(this Tile tile)
        {
            return tile.GetComponent<OccupiedTileFlagComponent>();
        }
        
        public static bool IsOccupied(this Tile tile)
        {
            return tile.HasComponent<OccupiedTileFlagComponent>();
        }
        
        public static void SetOccupied(this Tile tile, bool isOccupied)
        {
            if(isOccupied == true)
            {
                tile.AddComponent(new OccupiedTileFlagComponent());
            }
            else
            {
                tile.RemoveComponent(tile.GetComponent<OccupiedTileFlagComponent>());
            }
        }
        
        public static void GetPosition(this Tile tile, out Vector2Int position)
        {
            position = tile.GetComponent<TilePositionComponent>().Position;
        }
    }
}