using UnityEngine;
using UnityEngine.UI;

public class RPMMeterSettings2 : MonoBehaviour
{
    public Image MainColor;
    public Text VeloColor;
    public Text VeloUnitsColor;
    public Text GearColor;
    public Image NitroColor;
    public Image ArrowColor;
    public Image ArrowColor2;

    public Material Arrow;
    public Material Arrow2;
    public Material Main;
    public Material Nitro;
    public Material Text;

    void Start()
    {
        MainColor.color = Main.color;
        VeloColor.color = Text.color;
        VeloUnitsColor.color = Text.color;
        GearColor.color = Text.color;
        NitroColor.color = Nitro.color;
        ArrowColor.color = Arrow.color;
        ArrowColor2.color = Arrow2.color;
    }
}
