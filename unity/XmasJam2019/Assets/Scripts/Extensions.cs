using UnityEngine;
using UnityEngine.UI;

public static class Extensions
{
    // Generic
    public static void Destroy(this GameObject t)
    {
        Object.Destroy(t);
    }

    public static void Destroy(this Transform t)
    {
        Object.Destroy(t.gameObject);
    }

    public static void Destroy<T>(this T t) where T : MonoBehaviour
    {
        Object.Destroy(t);
    }

    public static void Disable<T>(this T t) where T : MonoBehaviour
    {
        t.enabled = false;
    }

    public static void Enable<T>(this T t) where T : MonoBehaviour
    {
        t.enabled = true;
    }

    public static void SetActive<T>(this T t, bool active) where T : MonoBehaviour
    {
        t.enabled = active;
    }
    
    public static GameObject Instantiate(this GameObject t)
    {
        return Object.Instantiate(t);
    }

    public static GameObject Instantiate(this Transform t)
    {
        return Instantiate(t.gameObject);
    }

    public static GameObject Instantiate(this GameObject t, Transform parant)
    {
        return Instantiate(t, parant);
    }

    public static void DestroyChildren(this Transform t)
    {
        for (var i = t.childCount - 1; i >= 0; i--)
            Object.Destroy(t.GetChild(i).gameObject);
    }

    public static void ChildsActiveState(this Transform t, bool state)
    {
        for (var i = t.childCount - 1; i >= 0; i--)
            t.GetChild(i).gameObject.SetActive(state);
    }

    public static void Reset(this Transform t)
    {
        t.localPosition = Vector3.zero;
        t.localEulerAngles = Vector3.zero;
        t.localScale = Vector3.one;
    }


    // Spriterenderer
    public static void SetColor(this SpriteRenderer spriteRenderer, Color color)
    {
        spriteRenderer.color = color;
    }

    public static void SetSprite(this SpriteRenderer spriteRenderer, Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }

    public static void SetSprite(this Image i, Sprite sprite)
    {
        i.sprite = sprite;
    }

    //text
    public static void SetText(this Text t, string text)
    {
        t.text = text;
    }

    //C# string 
    public static string Truncate(this string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value)) return value;
        return value.Length <= maxLength ? value : value.Substring(0, maxLength);
    }
}