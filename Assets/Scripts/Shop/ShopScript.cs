using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    //points = PlayerScript.PlayerPoints
    public static Color[] colors;
    public static string[] colorNames;
    public static int[] colorCosts;

    public Image colorImage;
    public Text colorText;
    public Text ColorCostText;
    public Text BuyOrSetButtonText;
    public int i;

    // Use this for initialization
    void Start()
    {
        //length = 5
        colors = new Color[] { Color.white, Color.black, Color.blue, Color.yellow, new Color(255, 193, 30) };
        colorNames = new string[] { "white", "black", "blue", "yellow", "gold" };
        colorCosts = new int[] { 0, 2, 5, 10, 30 };
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddInLoop(int num)
    {
        i = i + num;
        if (i >= colors.Length)
        {
            i = i - colors.Length;
        }
        else if (i < 0)
        {
            i = i + colors.Length;
        }
        SetColor();
    }

    private void SetColor()
    {
        colorImage.color = colors[i];
        colorText.text = colorNames[i];
        if (colorCosts[i] != 0)
        {
            ColorCostText.enabled = true;
            ColorCostText.text = "cost " + colorCosts[i];
            BuyOrSetButtonText.text = "Buy";
        }
        else
        {
            ColorCostText.enabled = false;
            BuyOrSetButtonText.text = "Set";
        }
    }
}
