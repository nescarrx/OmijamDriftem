using UnityEngine;

public class SmokeColor : MonoBehaviour
{
    [SerializeField] private Material smokeColor;

    [SerializeField] private ParticleSystem left;
    [SerializeField] private ParticleSystem right;

    [System.Obsolete]
    void Update()
    {
        Color color = smokeColor.color;
        color.a = 0.1f;
        left.startColor = color;
        right.startColor = color;
    }
}
