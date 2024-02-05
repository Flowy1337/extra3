using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class JsonLoader : MonoBehaviour
{
    [System.Serializable]
    public class JsonData
    {
        public List<string> textFields;
    }

    // Reference to your TextMeshPro field in Unity
    public TextMeshProUGUI textMeshProField;

    // Serialized field for the JSON data
    [SerializeField]
    private TextAsset jsonFile;

    // Index to keep track of the current string
    private int currentIndex = 0;

    // Declare jsonData here
    private JsonData jsonData;

    void Start()
    {
        LoadJsonData();
        ShowCurrentString();
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Increment index and show the next string
            currentIndex = (currentIndex + 1) % jsonData.textFields.Count;
            ShowCurrentString();
        }
    }

    void LoadJsonData()
    {
        // Load JSON data from the TextAsset
        if (jsonFile != null)
        {
            jsonData = JsonUtility.FromJson<JsonData>(jsonFile.text);
        }
        else
        {
            Debug.LogError("No JSON file assigned in the Unity Editor.");
        }
    }

    void ShowCurrentString()
    {
        // Display the current string in the TextMeshPro field
        if (jsonData != null && jsonData.textFields.Count > 0)
        {
            textMeshProField.text = jsonData.textFields[currentIndex];
        }
        else
        {
            Debug.LogError("Invalid or insufficient data in the JSON object.");
        }
    }
}