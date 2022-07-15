using UnityEngine;

public class carLightsPainter : MonoBehaviour
{
    [SerializeField] private Material lightsColor;
    [SerializeField] private Light light1;
    [SerializeField] private Light light2;

    [SerializeField] private Material neonsColor;
    [SerializeField] private Light neon1;
    [SerializeField] private Light neon2;
    [SerializeField] private Light neon3;
    [SerializeField] private Light neon4;

    void Start()
    {
        Color color = lightsColor.color;
        light1.color = color;
        light2.color = color;

        Color color2 = neonsColor.color;
        neon1.color = color2;
        neon2.color = color2;
        neon3.color = color2;
        neon4.color = color2;
    }
}
