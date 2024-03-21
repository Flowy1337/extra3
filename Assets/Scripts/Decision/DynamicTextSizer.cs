using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
[RequireComponent(typeof(BoxCollider2D))]
public class DynamicTextSizer : MonoBehaviour
{
    private TextMeshProUGUI textObject;
    private BoxCollider2D boxCollider;

    public float maxFontSize = 100f;
    public float minFontSize = 10f;
    public float fontResizeStep = 1f;

    void Start()
    {
        // Get the TextMeshProUGUI component
        textObject = GetComponent<TextMeshProUGUI>();

        // Get the BoxCollider2D component
        boxCollider = GetComponent<BoxCollider2D>();

        // Resize the text and collider initially
        ResizeTextAndCollider();
    }

    void Update()
    {
        // Resize the text and collider
        ResizeTextAndCollider();
    }

    void ResizeTextAndCollider()
    {
        float fontSize = maxFontSize;

        // Reduce font size until it fits within the bounds
        while (textObject.preferredWidth > boxCollider.size.x ||
               textObject.preferredHeight > boxCollider.size.y)
        {
            fontSize -= fontResizeStep;

            // Ensure font size stays within bounds
            if (fontSize < minFontSize)
            {
                break;
            }

            textObject.fontSize = fontSize;
        }

        // Update the box collider size to match the text size
        Vector2 newSize = new Vector2(textObject.preferredWidth, textObject.preferredHeight);
        boxCollider.size = newSize;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Decrease the font size upon collision
        textObject.fontSize -= fontResizeStep;

        // Resize the text and collider after font size change
        ResizeTextAndCollider();
    }
}