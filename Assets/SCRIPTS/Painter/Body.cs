using UnityEngine;

public class Body : MonoBehaviour
{
    [SerializeField] private Material carColor;

    public void SetColorRed()
    {
        carColor.color = Color.red;
    }
    public void SetColorBlue()
    {
        carColor.color = Color.blue;
    }
    public void SetColorGreen()
    {
        carColor.color = Color.green;
    }
    public void SetColorYellow()
    {
        carColor.color = Color.yellow;
    }
    public void SetColorBlack()
    {
        carColor.color = Color.black;
    }
    public void SetColorWhite()
    {
        carColor.color = Color.white;
    }
    public void SetColorLightBlue()
    {
        carColor.color = Color.cyan;
    }
    public void SetColorPink()
    {
        carColor.color = Color.magenta;
    }
    public void SetColorGrey()
    {
        carColor.color = Color.grey;
    }


}
