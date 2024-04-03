using System;
using System.Collections;
using System.Collections.Generic;
using Codice.Client.Commands.WkTree;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OpenBag : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject answer;
    public GameObject inventoryUI;
    private Inventory inventory;
    public List<GameObject> allObjects;
    private Image image;
    private Material material;

    void Start()
    { 
        inventory = Inventory.inventory;
        inventoryUI.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (text.enabled)
        {
            text.enabled = false;
            answer.SetActive(false);
            inventoryUI.SetActive(true);
            UpdateGrayScale();
            return;
        }
        inventoryUI.SetActive(false);
        answer.SetActive(true);
        text.enabled = true;
    }

    private void UpdateGrayScale()
    {
        foreach (var VARIABLE in allObjects)
        {
            image = VARIABLE.GetComponent<Image>();
            material = new Material(image.material);
            image.material = material;
            AllItems current = (AllItems)Enum.Parse(typeof(AllItems),VARIABLE.gameObject.name);
            if (inventory.contains(current))
            {
                image.material.SetFloat("_GrayscaleAmount",0);
                continue;
            }
            image.material.SetFloat("_GrayscaleAmount",1);

        }
    }
}
