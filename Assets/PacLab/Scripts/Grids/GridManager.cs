using Ludo.Singletons;
using UnityEngine;

namespace PacLab.Grids
{
    public class GridManager : MonoBehaviourSingleton<GridManager>
    {
        protected override bool IsPersistent => false;
    }
}