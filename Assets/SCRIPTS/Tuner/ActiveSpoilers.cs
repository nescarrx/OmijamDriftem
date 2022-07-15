using UnityEngine;

public class ActiveSpoilers : MonoBehaviour
{
    [SerializeField] private GameObject spoiler1;
    [SerializeField] private GameObject spoiler2;
    [SerializeField] private GameObject spoiler3;
    [SerializeField] private GameObject spoiler4;
    [SerializeField] private GameObject spoiler5;
    [SerializeField] private GameObject spoiler6;
    [SerializeField] private GameObject spoiler7;
    [SerializeField] private GameObject spoiler8;
    [SerializeField] private GameObject spoiler9;
    private void Start()
    {
        spoiler1.SetActive(false);
        spoiler2.SetActive(false);
        spoiler3.SetActive(false);
        spoiler4.SetActive(false);
        spoiler5.SetActive(false);
        spoiler6.SetActive(false);
        spoiler7.SetActive(false);
        spoiler8.SetActive(false);
        spoiler9.SetActive(false);
        if (PlayerPrefs.GetInt("spoiler") == 1)
        {
            spoiler1.SetActive(true);
        }

        if (PlayerPrefs.GetInt("spoiler") == 2)
        {
            spoiler2.SetActive(true);
        }

        if (PlayerPrefs.GetInt("spoiler") == 3)
        {
            spoiler3.SetActive(true);
        }

        if (PlayerPrefs.GetInt("spoiler") == 4)
        {
            spoiler4.SetActive(true);
        }

        if (PlayerPrefs.GetInt("spoiler") == 5)
        {
            spoiler5.SetActive(true);
        }

        if (PlayerPrefs.GetInt("spoiler") == 6)
        {
            spoiler6.SetActive(true);
        }

        if (PlayerPrefs.GetInt("spoiler") == 7)
        {
            spoiler7.SetActive(true);
        }

        if (PlayerPrefs.GetInt("spoiler") == 8)
        {
            spoiler8.SetActive(true);
        }

        if (PlayerPrefs.GetInt("spoiler") == 9)
        {
            spoiler9.SetActive(true);
        }
    }
}
