using Juhyeon.Units;
using UnityEngine;

namespace Juhyeon.Stage
{
    public class Tile : MonoBehaviour
    {
        public IUnit Unit { get; set; } = null;
        public Vector2Int Position { get; set; }
    }
}
