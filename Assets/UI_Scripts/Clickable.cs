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
        


    }

    void OnMouseOver()
    {
        if (!sizeUp)
        {
            Vector3 newScale = originalScale * scaleFactor;
            transform.localScale = newScale;

            sizeUp = true;


        }

        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Set Varaible accordingly");
        }
    }

   

    void OnMouseExit()
    {
        transform.localScale = originalScale;
        sizeUp = false;
        Debug.Log("Mouse exit: Object scaled down!");

    }
}
