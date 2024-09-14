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
    }
}