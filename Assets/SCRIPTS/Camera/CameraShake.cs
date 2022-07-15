using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private Volume volume;

    private ChromaticAberration CA;

    [SerializeField] private CameraController nitro;

    void Start()
    {
        volume.profile.TryGet<ChromaticAberration>(out CA);
        CA.intensity.value = 0f;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W) && nitro.NitroAmmount > 0)
        {
            Vector3 startPosition = transform.position;
            float strength = 0.01f;
            transform.position = startPosition + Random.insideUnitSphere * strength;
            CA.intensity.value = Mathf.Lerp(1f, 0f, 5f * Time.deltaTime);
        }
        else
        {
            CA.intensity.value = Mathf.Lerp(0f, 1f, 5f * Time.deltaTime);
        }

    }
}
