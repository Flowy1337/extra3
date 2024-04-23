using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTextHandy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextCanvas;
    public GameObject AnswerCanvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisableTextObjects()
    {
        TextCanvas.gameObject.SetActive(false);
        AnswerCanvas.gameObject.SetActive(false);

    }

    void EnableTextObjects()
    {
        TextCanvas.gameObject.SetActive(true);
        AnswerCanvas.gameObject.SetActive(true);
    }
    private void OnMouseDown()
    {
        Debug.Log("Called");
        if (AnswerCanvas.gameObject.activeSelf)
        {
            Debug.Log("Answer was active :O");
            DisableTextObjects();
            gameObject.transform.parent.gameObject.transform.parent.gameObject.SetActive(true);
            return;
        }
        if (!AnswerCanvas.gameObject.activeSelf)
        {
            Debug.Log("Answer was not active :O");
            gameObject.transform.parent.gameObject.transform.parent.gameObject.SetActive(false);
            EnableTextObjects();
        }
    }
}
