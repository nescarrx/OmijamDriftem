using UnityEngine;

public class ActiveHood : MonoBehaviour
{
    [SerializeField] private GameObject Hood1;
    [SerializeField] private GameObject Hood2;
    [SerializeField] private GameObject Hood3;

    void Start()
    {
        Hood1.SetActive(false);
        Hood2.SetActive(false);
        Hood3.SetActive(false);
        if (PlayerPrefs.GetInt("hood") == 2)
        {
            Hood2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("hood") == 3)
        {
            Hood3.SetActive(true);
        }
        else
        {
            Hood1.SetActive(true);
        }
    }
}
