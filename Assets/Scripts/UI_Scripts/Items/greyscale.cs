using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greyscale : MonoBehaviour
{
    // Start is called before the first frame update
    private Image image;
    private Material material;
    public TextAsset json;
    void Awake()
    {
        image = GetComponent<Image>();
        material = new Material(image.material);
        image.material = material;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GreyImage()
    {
        image.material.SetFloat("_GrayscaleAmount",1);
    }
}
