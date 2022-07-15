using UnityEngine;

public class BodyKit : MonoBehaviour
{
    [SerializeField] private Material bodyKitColor;

    public void SetColorRed()
    {
        bodyKitColor.color = Color.red;
    }
    public void SetColorBlue()
    {
        bodyKitColor.color = Color.blue;
    }
    public void SetColorGreen()
    {
        bodyKitColor.color = Color.green;
    }
    public void SetColorYellow()
    {
        bodyKitColor.color = Color.yellow;
    }
    public void SetColorWhite()
    {
        bodyKitColor.color = Color.white;
    }
    public void SetColorLightBlue()
    {
        bodyKitColor.color = Color.cyan;
    }
    public void SetColorPink()
    {
        bodyKitColor.color = Color.magenta;
    }
    public void SetColorGrey()
    {
        bodyKitColor.color = Color.gray;
    }
    public void SetColorBlack()
    {
        bodyKitColor.color = Color.black;
    }


}
