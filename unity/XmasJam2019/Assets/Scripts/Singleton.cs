using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance
    {
        get
        {
            if (GetInstanceIfNotNull == null)
            {
                object reference = FindObjectOfType<T>();
                if (reference == null)
                    reference = new GameObject("singleton::" + typeof(T)).AddComponent(typeof(T));
                GetInstanceIfNotNull = (T) reference;
            }

            return GetInstanceIfNotNull;
        }
    }

    public static T GetInstanceIfNotNull { get; private set; }

    public static bool IsInstanceNull => GetInstanceIfNotNull == null;

    private void OnDestroy()
    {
        GetInstanceIfNotNull = null;
    }
}