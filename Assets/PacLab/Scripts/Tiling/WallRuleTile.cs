using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


namespace PacLab.Tiling
{
    [CreateAssetMenu(menuName = "PacLab/2D/Tiles/Wall RuleTile", fileName = "WallRuleTile")]
    public class WallRuleTile : RuleTile<WallRuleTile.Neighbor>
    {
        public List<TileBase> innerTiles = new();

        public class Neighbor : RuleTile.TilingRule.Neighbor
        {
            public const int InnerTile = 3;
        }

        public override bool RuleMatch(int neighbor, TileBase tile)
        {
            return neighbor switch
            {
                Neighbor.InnerTile => innerTiles.Contains(tile),
                _ => base.RuleMatch(neighbor, tile)
            };
        }
    }
}