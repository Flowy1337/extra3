using UnityEngine;
using TMPro;

public class TextHoverHighlight : MonoBehaviour
{
    private TMP_Text textMesh;
    private Color originalColor;
    public Color hoverColor = Color.yellow;

    void Start()
    {
        // Get the TMP_Text component on the GameObject
        textMesh = GetComponent<TMP_Text>();

        // Store the original color of the text
        originalColor = textMesh.color;
    }

    void OnMouseEnter()
    {
        // Change the text color to the hover color when the mouse enters
        textMesh.color = hoverColor;
    }

    void OnMouseExit()
    {
        // Change the text color back to the original color when the mouse exits
        textMesh.color = originalColor;
    }
}
