using UnityEngine;

namespace PacLab.Grids
{
    public class GameGrid
    {
        private int _width;
        private int _height;
        
        private GridObject[,] _gridObjects;
        
        public int Width => _width;
        public int Height => _height;
        
        public GridObject[,] GridObjects => _gridObjects;
        
        public GameGrid(int width, int height)
        {
            _width = width;
            _height = height;
            _gridObjects = new GridObject[width, height];
            InitializeGrid();
        }
        
        private void InitializeGrid()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    Vector2Int cellPosition = new Vector2Int(x, y);
                    _gridObjects[x, y] = new GridObject(cellPosition);
                }
            }
        }
    }
}