using UnityEngine;

public class SmokeColor2 : MonoBehaviour
{
    [SerializeField] private Material smokeColor;

    [SerializeField] private ParticleSystem left;
    [SerializeField] private ParticleSystem right;
    [SerializeField] private ParticleSystem left2;
    [SerializeField] private ParticleSystem right2;

    [System.Obsolete]
    void Start()
    {
        Color color = smokeColor.color;
        color.a = 0.1f;
        left.startColor = color;
        right.startColor = color;
        left2.startColor = color;
        right2.startColor = color;
    }
}
