using UnityEngine;

public class Decision_Loader : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;

    void Start()
    {
        a1 = GameObject.FindGameObjectWithTag("Notepad");
        a2 = GameObject.FindGameObjectWithTag("A2");
        a3 = GameObject.FindGameObjectWithTag("A3");
        a4 = GameObject.FindGameObjectWithTag("A4");
    }

    // Use OnMouseDown instead of Update
    private void OnMouseDown()
    {
        CheckMouseClick(a1);
        CheckMouseClick(a2);
        CheckMouseClick(a3);
        CheckMouseClick(a4);
    }

    void CheckMouseClick(GameObject obj)
    {
        // Check if the mouse click is over the object
        if (obj != null && obj == gameObject)
        {
            Debug.Log("Clicked on " + obj.name+  " HALLLLO");
            // Perform actions when the object is clicked
        }
    }
}