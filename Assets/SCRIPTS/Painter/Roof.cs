using UnityEngine;
using UnityEngine.UI;

public class Roof : MonoBehaviour
{
    public Material roofColor;
    public Material bodyColor;

    public Image roof;

    public bool isBlackR;

    void Update()
    {
        Color bodyColors = bodyColor.color;
        roof.color = bodyColors;
    }

    public void setColorBlack()
    {
        roofColor.color = Color.black;
        isBlackR = true;
    }

    public void setBodyColor()
    {
        roofColor.color = roof.color;
        isBlackR = false;
    }


}
