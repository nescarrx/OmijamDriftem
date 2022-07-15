using UnityEngine;

public class RPMMeter : MonoBehaviour
{
    public Material Arrow;
    public Material Main;
    public Material Nitro;
    public Material Text;
    public Material Arrow2;

    //Arrow
    public void setArrowColorRed()
    {
        Arrow.color = Color.red;
        Color color = Color.red;
        color.r = 0.5f;
        Arrow2.color = color;
    }
    public void setArrowColorBlue()
    {
        Color color = Color.blue;
        color.b = 0.5f;
        Arrow2.color = color;
        Arrow.color = Color.blue;
    }
    public void setArrowColorGreen()
    {
        Color color = Color.green;
        color.g = 0.5f;
        Arrow2.color = color;
        Arrow.color = Color.green;
    }
    public void setArrowColorYellow()
    {
        Color color = Color.yellow;
        color.r = 0.5f;
        color.g = 0.5f;
        Arrow2.color = color;
        Arrow.color = Color.yellow;
    }
    public void setArrowColorWhite()
    {
        Color color = Color.white;
        color.r = 0.5f;
        color.g = 0.5f;
        color.b = 0.5f;
        Arrow2.color = color;
        Arrow.color = Color.white;
    }
    public void setArrowColorLightBlue()
    {
        Color color = Color.cyan;
        color.b = 0.5f;
        color.g = 0.5f;
        Arrow2.color = color;
        Arrow.color = Color.cyan;
    }
    public void setArrowColorPink()
    {
        Color color = Color.magenta;
        color.r = 0.5f;
        color.b = 0.5f;
        Arrow2.color = color;
        Arrow.color = Color.magenta;
    }
    public void setArrowColorGrey()
    {
        Arrow2.color = Color.black;
        Arrow.color = Color.gray;
    }
    //Main
    public void setColorRed()
    {
        Main.color = Color.red;
    }
    public void setColorBlue()
    {
        Main.color = Color.blue;
    }
    public void setColorGreen()
    {
        Main.color = Color.green;
    }
    public void setColorYellow()
    {
        Main.color = Color.yellow;
    }
    public void setColorWhite()
    {
        Main.color = Color.white;
    }
    public void setColorLightBlue()
    {
        Main.color = Color.cyan;
    }
    public void setColorPink()
    {
        Main.color = Color.magenta;
    }
    public void setColorGrey()
    {
        Main.color = Color.gray;
    }
    public void setColorBlack()
    {
        Main.color = Color.black;
    }
    //Texts
    public void setTextColorRed()
    {
        Text.color = Color.red;
    }
    public void setTextColorBlue()
    {
        Text.color = Color.blue;
    }
    public void setTextColorGreen()
    {
        Text.color = Color.green;
    }
    public void setTextColorYellow()
    {
        Text.color = Color.yellow;
    }
    public void setTextColorWhite()
    {
        Text.color = Color.white;
    }
    public void setTextColorLightBlue()
    {
        Text.color = Color.cyan;
    }
    public void setTextColorPink()
    {
        Text.color = Color.magenta;
    }
    public void setTextColorGrey()
    {
        Text.color = Color.gray;
    }
    public void setTextColorBlack()
    {
        Text.color = Color.black;
    }


    //Nitro
    public void setNitroColorRed()
    {
        Nitro.color = Color.red;
    }
    public void setNitroColorBlue()
    {
        Nitro.color = Color.blue;
    }
    public void setNitroColorGreen()
    {
        Nitro.color = Color.green;
    }
    public void setNitroColorYellow()
    {
        Nitro.color = Color.yellow;
    }
    public void setNitroColorWhite()
    {
        Nitro.color = Color.white;
    }
    public void setNitroColorLightBlue()
    {
        Nitro.color = Color.cyan;
    }
    public void setNitroColorPink()
    {
        Nitro.color = Color.magenta;
    }
    public void setNitroColorGrey()
    {
        Nitro.color = Color.gray;
    }
    public void setNitroColorBlack()
    {
        Nitro.color = Color.black;
    }
}
