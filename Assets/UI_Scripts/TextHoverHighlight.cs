using UnityEngine;
using TMPro;

public class TextHoverHighlight : MonoBehaviour
{
    private TMP_Text textMesh;
    private Color originalColor;
    public Color hoverColor = Color.yellow;
    public Animator animator;
    void Start()
    {
        // Get the TMP_Text component on the GameObject
        textMesh = GetComponent<TMP_Text>();
       
        // Store the original color of the text

        originalColor = textMesh.color;
        /*GameObject otherObject = GameObject.Find("CCTV");

        if (otherObject != null)
        {
            animator = otherObject.GetComponent<Animator>();
        }*/
    }

    void OnMouseEnter()
    {
        // Change the text color to the hover color when the mouse enters
        textMesh.color = hoverColor;
        //animator.SetBool("sizeUp", true);
    }

    void OnMouseExit()
    {
        // Change the text color back to the original color when the mouse exits
        textMesh.color = originalColor;
        //animator.SetBool("sizeUp", false);
    }
}
