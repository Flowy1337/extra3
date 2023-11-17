using UnityEngine;
using System.Collections;
public class Cursorbehav : MonoBehaviour
{
    void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = false;
    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit) && hit.collider.tag != "UI")
        {
            // Der Mauszeiger ist über dem Hintergrundbild
            Cursor.visible = true;
        }

        // Get the current mouse position in screen space
        Vector2 mousePosition = Input.mousePosition;

        // Convert the screen position to world space
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, -Camera.main.transform.position.z));

        // Set the GameObject position to the mouse position
        transform.position = mousePosition;
    }
   
}
