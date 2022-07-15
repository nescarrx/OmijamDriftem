using UnityEngine;

public class RaceTrigger : MonoBehaviour
{
    [SerializeField] private GameObject info;
    [SerializeField] private Behaviour raceMap;

    void Start()
    {
        info.SetActive(false);
    }
    private void OnTriggerEnter(Collider col)
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        info.SetActive(true);
        raceMap.enabled = true;
    }
    private void OnTriggerExit(Collider col)
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        info.SetActive(false);
    }
}