using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trunk : MonoBehaviour
{
    public Material trunkColor;
    public Material bodyColor;

    public Image trunk;

    public bool isBlackT;

    void Update()
    {
        Color bodyColors = bodyColor.color;
        trunk.color = bodyColors;
    }

    public void setColorBlack()
    {
        trunkColor.color = Color.black;
        isBlackT = true;
    }

    public void setBodyColor()
    {
        trunkColor.color = trunk.color;
        isBlackT = false;
    }


}
