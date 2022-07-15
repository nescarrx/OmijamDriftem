using UnityEngine;

public class Spoilers : MonoBehaviour
{
    [SerializeField] private GameObject spoiler1;
    [SerializeField] private GameObject spoiler2;
    [SerializeField] private GameObject spoiler3;
    [SerializeField] private GameObject spoiler4;
    [SerializeField] private GameObject spoiler5;
    [SerializeField] private GameObject spoiler6;

    public int spoilerName;

    void Update()
    {
        PlayerPrefs.SetInt("spoiler", spoilerName);
    }

    public void SetSpoilerFirst()
    {
        SetAllSpolersInactive();
        spoiler1.SetActive(true);
        spoilerName = 1;
    }

    public void SetSpoilerSecond()
    {
        SetAllSpolersInactive();
        spoiler2.SetActive(true);
        spoilerName = 2;
    }

    public void SetSpoilerThird()
    {
        SetAllSpolersInactive();
        spoiler3.SetActive(true);
        spoilerName = 3;
    }

    public void SetSpoilerForth()
    {
        SetAllSpolersInactive();
        spoiler4.SetActive(true);
        spoilerName = 4;
    }

    public void SetSpoilerFifth()
    {
        SetAllSpolersInactive();
        spoiler5.SetActive(true);
        spoilerName = 5;
    }

    public void SetSpoilerSixth()
    {
        SetAllSpolersInactive();
        spoiler6.SetActive(true);
        spoilerName = 6;
    }

    private void SetAllSpolersInactive()
    {
        spoiler1.SetActive(false);
        spoiler2.SetActive(false);
        spoiler3.SetActive(false);
        spoiler4.SetActive(false);
        spoiler5.SetActive(false);
        spoiler6.SetActive(false);
    }
}
