using UnityEngine;

namespace Juhyeon.StageSystem
{
    public class Stage : MonoBehaviour
    {
        private static Tile[,] field = null;

        public static void Initialize()
        {
            if (field == null)
            {
                field = new Tile[16, 16];
            }

            // prim 알고리즘으로 생성
        }

        public static EObjectType GetObject(Vector2Int position)
        {
            return field[position.y, position.x].Object;
        }
    }
}
