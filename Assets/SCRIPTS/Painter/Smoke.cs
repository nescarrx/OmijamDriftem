using UnityEngine;

public class Smoke : MonoBehaviour
{
    public Material smokeMat;
    void Start()
    {
        Color color = smokeMat.color;
        color.a = 0.3f;
        smokeMat.color = color;
    }

    public void setColorRed()
    {
        smokeMat.color = Color.red;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }
    public void setColorBlue()
    {
        smokeMat.color = Color.blue;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }
    public void setColorGreen()
    {
        smokeMat.color = Color.green;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }
    public void setColorYellow()
    {
        smokeMat.color = Color.yellow;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }
    public void setColorBlack()
    {
        smokeMat.color = Color.black;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }
    public void setColorWhite()
    {
        smokeMat.color = Color.white;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }
    public void setColorLightBlue()
    {
        smokeMat.color = Color.cyan;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }
    public void setColorPink()
    {
        smokeMat.color = Color.magenta;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }
    public void setColorGrey()
    {
        smokeMat.color = Color.grey;
        Color color = smokeMat.color;
        smokeMat.color = color;
    }


}
