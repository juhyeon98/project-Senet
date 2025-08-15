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
                    instance = FindFirstObjectByType<StageManager>();
                    if (instance == null)
                    {
                        GameObject managerObject = new GameObject(typeof(StageManager).Name);
                        instance = managerObject.AddComponent<StageManager>();
                    }
                }
                return instance;
            }
        }

        public Stage Stage { get; private set; }

        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
                LoadStage();
            }
        }

        private void LoadStage()
        {
            if (Stage == null)
            {
                Stage = FindFirstObjectByType<Stage>();
                if (Stage == null)
                {
                    GameObject stageObject = new GameObject(typeof(Stage).Name);
                    Stage = stageObject.AddComponent<Stage>();
                }
            }
            Stage.Initialize();
        }
    }
}
