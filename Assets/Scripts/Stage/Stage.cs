using Juhyeon.Attackable;
using UnityEngine;

namespace Juhyeon.StageSystem
{
    public class Stage : MonoBehaviour
    {
        private Tile[,] m_field = new Tile[16, 16];

        private Tile m_exitTile = null;

        public void Initialize() => CreateNewStage();

        public void ReGenerate()
        {
            foreach (Tile tile in m_field) tile.Reset();
            CreateNewStage();
        }

        private void CreateNewStage()
        {
            //prim algorithm
        }

        public IAttackable GetObject(Vector2Int position)
        {
            return m_field[position.y, position.x].OnTile;
        }
    }
}

//TODO
// - prim 알고리즘으로 스테이지 생성 로직
