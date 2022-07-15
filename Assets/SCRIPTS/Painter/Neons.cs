using UnityEngine;

public class Neons : MonoBehaviour
{
    public Material addonsColor;

    public GameObject NeonsGameObject;

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;

    public void setColorRed()
    {
        addonsColor.SetColor("_EmissionColor", Color.red * 10f);
        addonsColor.color = Color.red;
        light1.color = Color.red;
        light2.color = Color.red;
        light3.color = Color.red;
        light4.color = Color.red;
    }
    public void setColorBlue()
    {
        addonsColor.SetColor("_EmissionColor", Color.blue * 10f);
        addonsColor.color = Color.blue;
        light1.color = Color.blue;
        light2.color = Color.blue;
        light3.color = Color.blue;
        light4.color = Color.blue;
    }
    public void setColorGreen()
    {
        addonsColor.SetColor("_EmissionColor", Color.green * 10f);
        addonsColor.color = Color.green;
        light1.color = Color.green;
        light2.color = Color.green;
        light3.color = Color.green;
        light4.color = Color.green;
    }
    public void setColorYellow()
    {
        addonsColor.SetColor("_EmissionColor", Color.yellow * 10f);
        addonsColor.color = Color.yellow;
        light1.color = Color.yellow;
        light2.color = Color.yellow;
        light3.color = Color.yellow;
        light4.color = Color.yellow;
    }
    public void setColorWhite()
    {
        addonsColor.SetColor("_EmissionColor", Color.white * 10f);
        addonsColor.color = Color.white;
        light1.color = Color.white;
        light2.color = Color.white;
        light3.color = Color.white;
        light4.color = Color.white;
    }
    public void setColorLightBlue()
    {
        addonsColor.SetColor("_EmissionColor", Color.cyan * 10f);
        addonsColor.color = Color.cyan;
        light1.color = Color.cyan;
        light2.color = Color.cyan;
        light3.color = Color.cyan;
        light4.color = Color.cyan;
    }
    public void setColorPink()
    {
        addonsColor.SetColor("_EmissionColor", Color.magenta * 10f);
        addonsColor.color = Color.magenta;
        light1.color = Color.magenta;
        light2.color = Color.magenta;
        light3.color = Color.magenta;
        light4.color = Color.magenta;
    }
    public void setColorGrey()
    {
        addonsColor.SetColor("_EmissionColor", Color.gray * 10f);
        addonsColor.color = Color.gray;
        light1.color = Color.gray;
        light2.color = Color.gray;
        light3.color = Color.gray;
        light4.color = Color.gray;
    }


}
