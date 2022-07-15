using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class amortyzatory : MonoBehaviour
{
    public WheelCollider FLCol;
    public WheelCollider FRCol;
    public WheelCollider RLCol;
    public WheelCollider RRCol;

    public Transform car;

    public Transform FL;
    public Transform FR;
    public Transform RL;
    public Transform RR;

    public Transform BFL;
    public Transform BFR;
    public Transform BRL;
    public Transform BRR;

    public Slider slider;
    public Slider sliderOffset;
    public Slider sliderCamber;

    private float a;

    private void Start()
    {
        slider.onValueChanged.AddListener((v) =>
        {
            FLCol.suspensionDistance = v;
            FRCol.suspensionDistance = v;
            RLCol.suspensionDistance = v;
            RRCol.suspensionDistance = v;
        });
        sliderOffset.onValueChanged.AddListener((v2) =>
        {
            Vector3 FLC = new Vector3(v2, 0.15f, 0);
            Vector3 FRC = new Vector3(-v2, 0.15f, 0);
            FLCol.center = FLC;
            FRCol.center = FRC;
            RLCol.center = FLC;
            RRCol.center = FRC;
        });

    }
    void Update()
    {
        float camber = sliderCamber.value;
        PlayerPrefs.SetFloat("camber", camber);

        Quaternion FLWRotation;
        Vector3 FLWPosition;
        FLCol.GetWorldPose(out FLWPosition, out FLWRotation);
        FLWRotation.z = -camber;
        FL.transform.position = FLWPosition;
        FLWRotation.x = 0f;
        FL.transform.rotation = FLWRotation;

        Quaternion FRWRotation;
        Vector3 FRWPosition;
        FRCol.GetWorldPose(out FRWPosition, out FRWRotation);
        FRWRotation.z = camber;
        FR.transform.position = FRWPosition;
        FRWRotation.x = 0f;
        FR.transform.rotation = FRWRotation;

        Quaternion RLWRotation;
        Vector3 RLWPosition;
        RLCol.GetWorldPose(out RLWPosition, out RLWRotation);
        RLWRotation.z = -camber;
        RL.transform.position = RLWPosition;
        RLWRotation.x = 0f;
        RL.transform.rotation = RLWRotation;

        Quaternion RRWRotation;
        Vector3 RRWPosition;
        RRCol.GetWorldPose(out RRWPosition, out RRWRotation);
        RRWRotation.z = camber;
        RR.transform.position = RRWPosition;
        RRWRotation.x = 0f;
        RR.transform.rotation = RRWRotation;

        BFL.position = FL.transform.position;
        BFR.position = FR.transform.position;
        BRL.position = RL.transform.position;
        BRR.position = RR.transform.position;

        Quaternion newRotation = FL.transform.rotation;
        newRotation.x = 0f;
        newRotation.z = 0f;
        BFL.transform.rotation = newRotation;
        BFR.transform.rotation = newRotation;

        Vector3 newPos = car.position;
        newPos.x = 0f;
        newPos.z = 0f;
        car.position = newPos;
    }

    public void hydraulicSuspension()
    {
        StartCoroutine(suspension());
        a = 0;
    }
    IEnumerator suspension()
    {
        while (a<0.01f)
        {
            a += Time.deltaTime;
            FLCol.suspensionDistance = 0.6f;
            FRCol.suspensionDistance = 0.6f;
            RLCol.suspensionDistance = 0.25f;
            RRCol.suspensionDistance = 0.25f;
            yield return new WaitForSeconds(0.5f);
            FLCol.suspensionDistance = 0.25f;
            FRCol.suspensionDistance = 0.25f;
            RLCol.suspensionDistance = 0.6f;
            RRCol.suspensionDistance = 0.6f;
            yield return new WaitForSeconds(0.5f);
            RLCol.suspensionDistance = 0.25f;
            RRCol.suspensionDistance = 0.25f;
            yield return new WaitForSeconds(0.5f);
            RLCol.suspensionDistance = 0.6f;
            RRCol.suspensionDistance = 0.6f;
            yield return new WaitForSeconds(0.5f);
            RLCol.suspensionDistance = 0.25f;
            RRCol.suspensionDistance = 0.25f;
        }
    }
}
