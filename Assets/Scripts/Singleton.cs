using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T m_instance;
    private static readonly object m_lock = new object();
    private static bool b_applicationIsQuitting = false;


    public static T Instance
    {
        get
        {
            if (b_applicationIsQuitting) return null;
            lock (m_lock)
            {
                if (m_instance == null)
                {
                    m_instance = FindFirstObjectByType<T>();
                    if (m_instance == null)
                    {
                        var obj = new GameObject(typeof(T).Name);
                        m_instance = obj.AddComponent<T>();
                        DontDestroyOnLoad(obj);
                    }
                }
            }
            return m_instance;
        }
    }

    protected virtual void OnDestroy()
    {
        b_applicationIsQuitting = true;
    }
}
