using UnityEngine;

namespace Juhyeon.StageSystem
{
    public class StageManager : MonoBehaviour
    {
        private static StageManager instance = null;

        public static StageManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StageManager();
                }
                return instance;
            }
        }
    }
}
