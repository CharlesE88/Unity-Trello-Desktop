using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTemplate
{
    public GameObject prefabButton;
    public Transform gridLayout;
    public string buttonText;
    public Sprite boardImage;
    public Button button;

    public ButtonTemplate(GameObject prefabBtn, Transform grid ,string buttonTxt, Sprite boardImg)
    {
        prefabButton = prefabBtn;
        gridLayout = grid;
        buttonText = buttonTxt;
        boardImage = boardImg;
    }
}
