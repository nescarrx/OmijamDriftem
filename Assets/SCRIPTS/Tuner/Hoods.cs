using UnityEngine;

public class Hoods : MonoBehaviour
{
    [SerializeField] private int hoodNumber;

    void Update()
    {
        PlayerPrefs.SetInt("hood", hoodNumber);
    }

    public void InstallHood1()
    {
        hoodNumber = 1;
    }

    public void InstallHood2()
    {
        hoodNumber = 2;
    }

    public void InstallHood3()
    {
        hoodNumber = 3;
    }
}
