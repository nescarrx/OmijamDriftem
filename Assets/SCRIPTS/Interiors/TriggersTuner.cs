using UnityEngine;

public class TriggersTuner : MonoBehaviour
{
    [SerializeField] private Behaviour TunerInterior;
    [SerializeField] private GameObject Tip;
    private void OnTriggerEnter(Collider col)
    {
        TunerInterior.enabled = true;
        Tip.SetActive(true);
    }
    private void OnTriggerExit(Collider col)
    {
        TunerInterior.enabled = false;
        Tip.SetActive(false);
    }
}

