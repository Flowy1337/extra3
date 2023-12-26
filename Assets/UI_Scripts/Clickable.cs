using TMPro;
using UnityEngine;

public class MouseHoverCheck : MonoBehaviour
{
    private Vector3 originalScale;
    bool sizeUp = false;
    public float scaleFactor = 1.2f;
    public TextMeshProUGUI txt;
    private bool selected = false;
    private Handy handy = Handy.Instanz;
    void Start()
    {
        originalScale = transform.localScale;
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
            if (txt.enabled)
            {
                handy.open_item();
                txt.enabled = false;
            }
            else
            {
                handy.close_item();
                handy.insert_text(txt.text);
                txt.enabled = true;
            }
        }
    }

   

    void OnMouseExit()
    {
        transform.localScale = originalScale;
        sizeUp = false;
    }
}
