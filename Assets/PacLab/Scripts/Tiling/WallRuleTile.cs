using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


namespace PacLab.Tiling
{
    [CreateAssetMenu(menuName = "PacLab/2D/Tiles/Wall RuleTile", fileName = "WallRuleTile")]
    public class WallRuleTile : RuleTile<WallRuleTile.Neighbor>
    {
        public List<TileBase> walkableTiles = new();
        public class Neighbor : RuleTile.TilingRule.Neighbor
        {
            public const int WalkableTile = 3;
        }

        public override bool RuleMatch(int neighbor, TileBase tile)
        {
            return neighbor switch
            {
                Neighbor.WalkableTile => walkableTiles.Contains(tile),
                _ => base.RuleMatch(neighbor, tile)
            };
        }
    }
}