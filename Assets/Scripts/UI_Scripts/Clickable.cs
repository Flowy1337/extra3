using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MouseHoverCheck : MonoBehaviour
{
    private Vector3 originalScale;
    bool sizeUp = false;
    public float scaleFactor = 1.2f;
    public TextMeshProUGUI txt;
    private bool selected = false;
    private Handy handy = Handy.Instanz;
    private GameObject notePad;
    public SpriteRenderer sptr;
    void Start()
    {
        originalScale = transform.localScale;
        notePad = GameObject.FindGameObjectWithTag("Notepad");

    }

    public bool foo()
    {
        handy.open_item();
        return this.handy.Active();
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
                foo();
                txt.enabled = false;
                sptr = notePad.GetComponent<SpriteRenderer>();
                sptr.enabled = false;
            }
            else
            {
                handy.close_item();
                handy.insert_text(txt.text);
                sptr.enabled = true;

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
