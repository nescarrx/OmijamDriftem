using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CameraRotate : MonoBehaviour
{
    public GameObject car1;
    public bool car1Bool;
    public GameObject car2;
    public bool car2Bool;
    public GameObject car3;
    public bool car3Bool;

    int carNumber;

    public Image MaxSpeed;
    public Image Handling;
    public Image Acceleration;

    public CarController car1Settings;
    public CarController car2Settings;
    public CarController car3Settings;

    float MaxSpeedcar1;
    float MaxSpeedcar2;
    float MaxSpeedcar3;
    float Acccar1;
    float Acccar2;
    float Acccar3;
    float Handcar1;
    float Handcar2;
    float Handcar3;

    int carNo = 1;

    public Image Selected;
    public Image Next;
    public Image Prev;

    public Sprite B;
    public Sprite G;
    public Sprite S;

    public TMP_Text WheelDrive;


    public float rotationSpeed;
    void Start()
    {
        Selected.GetComponent<Image>().sprite = B;
        Prev.GetComponent<Image>().sprite = G;
        Next.GetComponent<Image>().sprite = S;
        MaxSpeedcar1 = car1Settings.maxSpeed;
        MaxSpeedcar2 = car2Settings.maxSpeed;
        MaxSpeedcar3 = car3Settings.maxSpeed;
        Acccar1 = car1Settings.accelerationMultiplier;
        Acccar2 = car2Settings.accelerationMultiplier;
        Acccar3 = car3Settings.accelerationMultiplier;
        Handcar1 = car1Settings.steeringSpeed;
        Handcar2 = car2Settings.steeringSpeed;
        Handcar3 = car3Settings.steeringSpeed;
    }
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        if (car1Bool)
        {
            car1.SetActive(true);
            MaxSpeed.fillAmount = MaxSpeedcar1 / 400;
            Acceleration.fillAmount = Acccar1 / 100;
            Handling.fillAmount = Handcar1;
        }
        else if (car2Bool)
        {
            car2.SetActive(true);
            MaxSpeed.fillAmount = MaxSpeedcar2 / 400;
            Acceleration.fillAmount = Acccar2 / 100;
            Handling.fillAmount = Handcar2;
        }
        else if (car3Bool)
        {
            car3.SetActive(true);
            MaxSpeed.fillAmount = MaxSpeedcar3 / 400;
            Acceleration.fillAmount = Acccar3 / 100;
            Handling.fillAmount = Handcar3;
        }
        ChooseCar();
        PlayerPrefs.SetInt("car", carNumber);
    }

    private void ChooseCar()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            carNo--;
            if (carNo < 0)
            {
                carNo = 2;
            }
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            carNo++;
            if(carNo > 2)
            {
                carNo = 0;
            }
        }
        if (carNo == 1)//Selected
        {
            Selected.GetComponent<Image>().sprite = B;
            Prev.GetComponent<Image>().sprite = G;
            Next.GetComponent<Image>().sprite = S;
            SetAllCarsInactive();
            car1Bool = true;
            car1.SetActive(true);
            carNumber = 1;
            WheelDrive.text = "RWD";
        }
        if (carNo == 0)
        {
            Selected.GetComponent<Image>().sprite = G;
            Prev.GetComponent<Image>().sprite = S;
            Next.GetComponent<Image>().sprite = B;
            SetAllCarsInactive();
            car2Bool = true;
            car2.SetActive(true);
            carNumber = 2;
            WheelDrive.text = "FWD";
        }
        if (carNo == 2)
        {
            Selected.GetComponent<Image>().sprite = S;
            Prev.GetComponent<Image>().sprite = B;
            Next.GetComponent<Image>().sprite = G;
            SetAllCarsInactive();
            car3Bool = true;
            car3.SetActive(true);
            carNumber = 3;
            WheelDrive.text = "AWD";
        }
    }

    private void SetAllCarsInactive()
    {
        car1Bool = false;
        car2Bool = false;
        car3Bool = false;
        car1.SetActive(false);
        car2.SetActive(false);
        car3.SetActive(false);
    }
}
