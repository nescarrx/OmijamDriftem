using UnityEngine;

public class AreNeonsActive : MonoBehaviour
{
    [SerializeField] private GameObject neons;
    void Update()
    {
        if (PlayerPrefs.GetInt("neon") == 1)
        {
            neons.SetActive(true);
        }
        else
        {
            neons.SetActive(false);
        }
    }
}
