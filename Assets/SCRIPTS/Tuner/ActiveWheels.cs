using UnityEngine;

public class ActiveWheels : MonoBehaviour
{
    [SerializeField] private GameObject[] Wheel1;
    [SerializeField] private GameObject[] Wheel2;
    [SerializeField] private GameObject[] Wheel3;
    [SerializeField] private GameObject[] Wheel4;
    [SerializeField] private GameObject[] Wheel5;
    [SerializeField] private GameObject[] Wheel6;
    [SerializeField] private GameObject[] Wheel7;

    void Start()
    {
        if (PlayerPrefs.GetInt("wheelsNumber") == 1)
        {
            foreach (var wheel in Wheel1)
            {
                wheel.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("wheelsNumber") == 2)
        {
            foreach (var wheel in Wheel2)
            {
                wheel.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("wheelsNumber") == 3)
        {
            foreach (var wheel in Wheel3)
            {
                wheel.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("wheelsNumber") == 4)
        {
            foreach (var wheel in Wheel4)
            {
                wheel.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("wheelsNumber") == 5)
        {
            foreach (var wheel in Wheel5)
            {
                wheel.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("wheelsNumber") == 6)
        {
            foreach (var wheel in Wheel6)
            {
                wheel.SetActive(true);
            }
        }
        if (PlayerPrefs.GetInt("wheelsNumber") == 7)
        {
            foreach (var wheel in Wheel7)
            {
                wheel.SetActive(true);
            }
        }
    }
}
