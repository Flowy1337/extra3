using UnityEngine;

public class MouseHoverCheck : MonoBehaviour
{
    private Vector3 originalScale;
    bool sizeUp = false;
    public float scaleFactor = 1.2f;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        // Additional logic in the Update method if needed
    }

    void OnMouseOver()
    {
        if (!sizeUp)
        {
            Vector3 newScale = originalScale * scaleFactor;
            transform.localScale = newScale;

            sizeUp = true;
            Debug.Log("Mouse over: Object scaled up!");
        }
        Debug.Log("Mouse over: Object scaled up!");
    }

    void OnMouseExit()
    {
        transform.localScale = originalScale;
        sizeUp = false;
        Debug.Log("Mouse exit: Object scaled down!");
    }
}
