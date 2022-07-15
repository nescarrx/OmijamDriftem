using UnityEngine;

public class TriggersPainter : MonoBehaviour
{
    [SerializeField] private Behaviour GarageInterior;
    [SerializeField] private GameObject Tip;
    private void OnTriggerEnter(Collider col)
    {
        GarageInterior.enabled = true;
        Tip.SetActive(true);
    }
    private void OnTriggerExit(Collider col)
    {
        GarageInterior.enabled = false;
        Tip.SetActive(false);
    }
}

