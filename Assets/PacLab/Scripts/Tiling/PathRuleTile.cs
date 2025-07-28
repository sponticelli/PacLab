using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace PacLab.Tiling
{
    [CreateAssetMenu(menuName = "PacLab/2D/Tiles/Path RuleTile", fileName = "PathRuleTile")]
    public class PathRuleTile : RuleTile<PathRuleTile.Neighbor>
    {
        public List<TileBase> wallTiles = new();
        public class Neighbor : RuleTile.TilingRule.Neighbor
        {
            public const int WallTile = 4;
        }

        public override bool RuleMatch(int neighbor, TileBase tile)
        {
            return neighbor switch
            {
                Neighbor.WallTile => wallTiles.Contains(tile),
                _ => base.RuleMatch(neighbor, tile)
            };
        }
    }
}