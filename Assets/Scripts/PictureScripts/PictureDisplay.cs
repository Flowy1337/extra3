using UnityEngine;
using UnityEngine.UI;

public class PictureDisplay : MonoBehaviour
{
    public Image imageComponent;
    public Sprite[] pictureSprites; // Array to hold references to your pictures
    public int indx = 0;



    public void DisplayPicture(int pictureIndex)
    {
        imageComponent.sprite = pictureSprites[pictureIndex];
    }
}