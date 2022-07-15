using UnityEngine;

public class WheelsTuner : MonoBehaviour
{
    [SerializeField] private int wheelsNumber;
    void Update()
    {
        PlayerPrefs.SetInt("wheelsNumber", wheelsNumber);
    }

    public void Wheels1st()
    {
        wheelsNumber = 1;
    }

    public void Wheels2th()
    {
        wheelsNumber = 2;
    }
    public void Wheels3th()
    {
        wheelsNumber = 3;
    }

    public void Wheels4th()
    {
        wheelsNumber = 4;
    }
    public void Wheels5th()
    {
        wheelsNumber = 5;
    }

    public void Wheels6th()
    {
        wheelsNumber = 6;
    }
    public void Wheels7th()
    {
        wheelsNumber = 7;
    }
}
