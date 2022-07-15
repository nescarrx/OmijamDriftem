using UnityEngine;
using UnityEngine.UI;

public class Hood : MonoBehaviour
{
    public Material hoodColor;
    public Material bodyColor;

    public Image hood;

    public bool isBlackH;

    void Update()
    {
        Color bodyColors = bodyColor.color;
        hood.color = bodyColors;
    }

    public void setColorBlack()
    {
        hoodColor.color = Color.black;
        isBlackH = true;
    }

    public void setBodyColor()
    {
        hoodColor.color = hood.color;
        isBlackH = false;
    }


}
