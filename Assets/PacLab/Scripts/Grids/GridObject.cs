using UnityEngine;

namespace PacLab.Grids
{
    public class GridObject
    {
        private Vector2Int _cellPosition;
        
        public Vector2Int CellPosition => _cellPosition;
        
        public GridObject(Vector2Int cellPosition)
        {
            _cellPosition = cellPosition;
        }
    }
}