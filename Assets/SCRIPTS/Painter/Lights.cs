using UnityEngine;

public class Lights : MonoBehaviour
{
    public Material lightsColor;
    public Light light1;
    public Light light2;

    public void setColorRed()
    {
        lightsColor.SetColor("_EmissionColor", Color.red);
        lightsColor.color = Color.red;
        light1.color = Color.red;
        light2.color = Color.red;
    }
    public void setColorBlue()
    {
        lightsColor.SetColor("_EmissionColor", Color.blue);
        lightsColor.color = Color.blue;
        light1.color = Color.blue;
        light2.color = Color.blue;
    }
    public void setColorGreen()
    {
        lightsColor.SetColor("_EmissionColor", Color.green);
        lightsColor.color = Color.green;
        light1.color = Color.green;
        light2.color = Color.green;
    }
    public void setColorYellow()
    {
        lightsColor.SetColor("_EmissionColor", Color.yellow);
        lightsColor.color = Color.yellow;
        light1.color = Color.yellow;
        light2.color = Color.yellow;
    }
    public void setColorWhite()
    {
        lightsColor.SetColor("_EmissionColor", Color.white);
        lightsColor.color = Color.white;
        light1.color = Color.white;
        light2.color = Color.white;
    }
    public void setColorLightBlue()
    {
        lightsColor.SetColor("_EmissionColor", Color.cyan);
        lightsColor.color = Color.cyan;
        light1.color = Color.cyan;
        light2.color = Color.cyan;
    }
    public void setColorPink()
    {
        lightsColor.SetColor("_EmissionColor", Color.magenta);
        lightsColor.color = Color.magenta;
        light1.color = Color.magenta;
        light2.color = Color.magenta;
    }
    public void setColorGrey()
    {
        lightsColor.SetColor("_EmissionColor", Color.grey);
        lightsColor.color = Color.grey;
        light1.color = Color.grey;
        light2.color = Color.grey;
    }


}
