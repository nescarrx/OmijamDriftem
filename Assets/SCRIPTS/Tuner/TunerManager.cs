using UnityEngine;

public class TunerManager : MonoBehaviour
{
    [SerializeField] private Transform Cam;
    [SerializeField] private Transform Rotator;

    [SerializeField] private GameObject Spoiler;
    [SerializeField] private Transform SpoilerCam;
    [SerializeField] private Transform SpoilerRotate;

    [SerializeField] private GameObject Hood;
    [SerializeField] private Transform HoodCam;
    [SerializeField] private Transform HoodRotate;

    [SerializeField] private GameObject Wheels;
    [SerializeField] private Transform wheelsCam;
    void Start()
    {
        Spoiler.SetActive(false);
        Hood.SetActive(false);
        Wheels.SetActive(false);
    }

    void Update()
    {
        transform.Rotate(0, 10f * Time.deltaTime, 0);
    }

    public void Spoilers()
    {
        Spoiler.SetActive(true);
        Hood.SetActive(false);
        Wheels.SetActive(false);
        Rotator.position = SpoilerRotate.position;
        Cam.SetPositionAndRotation(SpoilerCam.position, SpoilerCam.rotation);
        Cam.LookAt(SpoilerRotate);
    }

    public void Hoods()
    {
        Hood.SetActive(true);
        Spoiler.SetActive(false);
        Wheels.SetActive(false);
        Rotator.position = HoodRotate.position;
        Cam.SetPositionAndRotation(HoodCam.position, HoodCam.rotation);
        Cam.LookAt(HoodRotate);
    }

    public void WheelsWindow()
    {
        Hood.SetActive(false);
        Spoiler.SetActive(false);
        Wheels.SetActive(true);
        Cam.SetPositionAndRotation(wheelsCam.position, wheelsCam.rotation);
    }
}
