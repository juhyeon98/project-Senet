using Juhyeon.Attackable;
using UnityEngine;

namespace Juhyeon.StageSystem
{
    public class Stage : MonoBehaviour
    {
        private Tile[,] field = new Tile[16, 16];

        public void Initialize()
        {
            // prim 알고리즘으로 생성
        }

        public IAttackable GetObject(Vector2Int position)
        {
            return field[position.y, position.x].OnTile;
        }
    }
}
