using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    [Space(10)]
    [Header("CAR SETUP")]
    [Space(10)]
    [Range(20, 420)]
    public int maxSpeed = 90;
    [Range(10, 80)]
    public int maxReverseSpeed = 45;
    [Range(1, 100)]
    public int accelerationMultiplier = 2;
    [Space(10)]
    [Range(10, 45)]
    public int maxSteeringAngle = 27;
    [Range(0.1f, 1f)]
    public float steeringSpeed = 0.5f;
    [Space(10)]
    [Range(100, 1000)]
    public int brakeForce = 350;
    [Range(1, 10)]
    public int decelerationMultiplier = 2;
    [Range(1, 10)]
    public int handbrakeDriftMultiplier = 5;
    [Space(10)]
    public Vector3 bodyMassCenter;
    private bool zryw = false;

    [Space(10)]
    [Header("Drift Menu")]
    [Space(10)]
    [SerializeField] private Text totalDrift;
    [SerializeField] private Text bestDrift;
    [SerializeField] private Text drift;
    [SerializeField] private Text driftMultiplierText;
    [SerializeField] private Image timerImage;
    [SerializeField] private GameObject driftMenu;
    private float driftpoints;
    private float bestpoints;
    private float totalpoints;
    private float driftMultiplierFloat;
    private float currentTime = 0f;
    readonly float MaxTime = 2f;

    [Space(10)]
    [Header("WheelDrive")]
    [Space(10)]
    [SerializeField] private bool AWD;
    [SerializeField] private bool FWD;
    [SerializeField] private bool RWD;

    [Space(10)]
    [Header("Nitro")]
    [Space(10)]
    [SerializeField] private Image nitroIcon;
    [SerializeField] private float nitroAmmount;
    [SerializeField] private GameObject nitroMeneger;
    [SerializeField] private ParticleSystem nitroLeft;
    [SerializeField] private ParticleSystem nitroRight;
    private float nitroBoost;

    [Space(10)]
    [Header("Exhaust")]
    [Space(10)]
    [SerializeField] private ParticleSystem rightExha;
    [SerializeField] private ParticleSystem leftExha;
    private float actualGear = 1;

    [Space(10)]
    [Header("WHEELS")]
    [Space(10)]
    [SerializeField] private GameObject frontLeftMesh;
    [SerializeField] private WheelCollider frontLeftCollider;
    [SerializeField] private GameObject FLBrakes;
    [Space(10)]
    [SerializeField] private GameObject frontRightMesh;
    [SerializeField] private WheelCollider frontRightCollider;
    [SerializeField] private GameObject FRBrakes;
    [Space(10)]
    [SerializeField] private GameObject rearLeftMesh;
    [SerializeField] private WheelCollider rearLeftCollider;
    [SerializeField] private GameObject RLBrakes;
    [Space(10)]
    [SerializeField] private GameObject rearRightMesh;
    [SerializeField] private WheelCollider rearRightCollider;
    [SerializeField] private GameObject RRBrakes;

    [Space(10)]
    [Header("EFFECTS")]
    [Space(10)]
    [SerializeField] private ParticleSystem RLWParticleSystem;
    [SerializeField] private ParticleSystem RRWParticleSystem;
    [SerializeField] private ParticleSystem FLWParticleSystem;
    [SerializeField] private ParticleSystem FRWParticleSystem;
    [SerializeField] private ParticleSystem TireSmoke1;
    [SerializeField] private ParticleSystem TireSmoke2;
    [Space(10)]
    [SerializeField] private TrailRenderer RLWTireSkid;
    [SerializeField] private TrailRenderer RRWTireSkid;
    [SerializeField] private TrailRenderer FLWTireSkid;
    [SerializeField] private TrailRenderer FRWTireSkid;
    [Space(10)]
    [SerializeField] private Renderer ReverseLights;
    [SerializeField] private Renderer BrakesLights;
    private bool direction;

    [Space(10)]
    [Header("UI")]
    [Space(10)]
    [SerializeField] private Text carSpeedText;

    [Space(10)]
    [Header("Meters")]
    [Space(10)]
    [SerializeField] private float MAX_Rotation_Angle = -145;
    [SerializeField] private float ZERO_Rotation_Angle = 25;
    [SerializeField] private Text gearUI;
    [SerializeField] private RectTransform arrow;
    private int gear;
    private float gearMultiplier;
    private float RPMs;

    [Space(10)]
    [Header("Sensors")]
    [Space(10)]
    [SerializeField] private Transform rearSensor;
    [SerializeField] private Transform frontSensor;
    [SerializeField] private LineRenderer line;
    [SerializeField] private LineRenderer line2;
    [SerializeField] private LineRenderer line3;
    [SerializeField] private LineRenderer line4;
    [SerializeField] private Material SensorsMat;
    [SerializeField] private Material SensorsMat2;
    [SerializeField] private Material SensorsMat3;
    [SerializeField] private Material SensorsMat4;
    [SerializeField] private TextMeshPro scoreFL;
    [SerializeField] private TextMeshPro scoreFR;
    [SerializeField] private TextMeshPro scoreRL;
    [SerializeField] private TextMeshPro scoreRR;
    [SerializeField] private Transform score1;
    [SerializeField] private Transform score2;
    [SerializeField] private Transform score3;
    [SerializeField] private Transform score4;
    private float pointsFL;
    private float pointsFR;
    private float pointsRL;
    private float pointsRR;
    readonly float sensorLength = 5.5f;
    readonly float sensorsAngle = 30f;

    [Space(10)]
    [Header("Sounds")]
    [Space(10)]
    [SerializeField] private AudioSource carEngineSound;
    [SerializeField] private AudioSource tireScreechSound;
    private float initialCarEngineSoundPitch;

    [Space(10)]
    [Header("Cam")]
    [Space(10)]
    [SerializeField] private Transform cam;
    private float carSpeed;
    private bool isDrifting;
    private bool Crash = false;

    Rigidbody carRigidbody;
    float steeringAxis;
    float throttleAxis;
    float driftingAxis;
    float localVelocityZ;
    float localVelocityX;
    bool deceleratingCar;

    WheelFrictionCurve FLwheelFriction;
    float FLWextremumSlip;
    WheelFrictionCurve FRwheelFriction;
    WheelFrictionCurve RLwheelFriction;
    float RLWextremumSlip;
    WheelFrictionCurve RRwheelFriction;
    float RRWextremumSlip;

    public float NitroAmmount => nitroAmmount;
    private void Awake()
    {
        carRigidbody = gameObject.GetComponent<Rigidbody>();
        carRigidbody.centerOfMass = bodyMassCenter;

        ReverseLights.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
        BrakesLights.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
    }
    private void Start()
    {
        FLwheelFriction = new WheelFrictionCurve
        {
            extremumSlip = frontLeftCollider.sidewaysFriction.extremumSlip,
            extremumValue = frontLeftCollider.sidewaysFriction.extremumValue,
            asymptoteSlip = frontLeftCollider.sidewaysFriction.asymptoteSlip,
            asymptoteValue = frontLeftCollider.sidewaysFriction.asymptoteValue,
            stiffness = frontLeftCollider.sidewaysFriction.stiffness
        };
        FLWextremumSlip = frontLeftCollider.sidewaysFriction.extremumSlip;

        FRwheelFriction = new WheelFrictionCurve
        {
            extremumSlip = frontRightCollider.sidewaysFriction.extremumSlip,
            extremumValue = frontRightCollider.sidewaysFriction.extremumValue,
            asymptoteSlip = frontRightCollider.sidewaysFriction.asymptoteSlip,
            asymptoteValue = frontRightCollider.sidewaysFriction.asymptoteValue,
            stiffness = frontRightCollider.sidewaysFriction.stiffness
        };

        RLwheelFriction = new WheelFrictionCurve
        {
            extremumSlip = rearLeftCollider.sidewaysFriction.extremumSlip,
            extremumValue = rearLeftCollider.sidewaysFriction.extremumValue,
            asymptoteSlip = rearLeftCollider.sidewaysFriction.asymptoteSlip,
            asymptoteValue = rearLeftCollider.sidewaysFriction.asymptoteValue,
            stiffness = rearLeftCollider.sidewaysFriction.stiffness
        };
        RLWextremumSlip = rearLeftCollider.sidewaysFriction.extremumSlip;

        RRwheelFriction = new WheelFrictionCurve
        {
            extremumSlip = rearRightCollider.sidewaysFriction.extremumSlip,
            extremumValue = rearRightCollider.sidewaysFriction.extremumValue,
            asymptoteSlip = rearRightCollider.sidewaysFriction.asymptoteSlip,
            asymptoteValue = rearRightCollider.sidewaysFriction.asymptoteValue,
            stiffness = rearRightCollider.sidewaysFriction.stiffness
        };
        RRWextremumSlip = rearRightCollider.sidewaysFriction.extremumSlip;

        initialCarEngineSoundPitch = carEngineSound.pitch;

        InvokeRepeating(nameof(CarSpeedUI), 0f, 0.1f);
        InvokeRepeating(nameof(CarSounds), 0f, 0.1f);
    }

    private void Update()
    {
        SetScoresTowardsPlayer();

        carSpeed = carRigidbody.velocity.magnitude * 3.6f;
        localVelocityX = transform.InverseTransformDirection(carRigidbody.velocity).x;
        localVelocityZ = transform.InverseTransformDirection(carRigidbody.velocity).z;

        if (Input.GetKey(KeyCode.W))
        {
            CancelInvoke("DecelerateCar");
            deceleratingCar = false;
            GoForward();
        }
        if (Input.GetKey(KeyCode.S))
        {
            CancelInvoke("DecelerateCar");
            deceleratingCar = false;
            GoReverse();
        }
        if (Input.GetKey(KeyCode.A))
        {
            TurnLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            TurnRight();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            CancelInvoke("DecelerateCar");
            deceleratingCar = false;
            Handbrake();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            RecoverTraction();
        }
        if (!Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W))
        {
            ThrottleOff();
        }
        if ((!Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.W)) && !Input.GetKey(KeyCode.Space) && !deceleratingCar)
        {
            InvokeRepeating(nameof(DecelerateCar), 0f, 0.1f);
            deceleratingCar = true;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && steeringAxis != 0f)
        {
            ResetSteeringAngle();
        }
        AnimateWheelMeshes();
        Suspension();
        RpmMeter();
        DriftPoints();
        Nitro();
        Lights();
        ExhaFire();
        Sensors();
    }

    private void CarSounds()
    {
          if (carEngineSound != null)
          {
              float engineSoundPitch = initialCarEngineSoundPitch + (Mathf.Abs(RPMs) / 7000f) * 2.2f;
              carEngineSound.pitch = engineSoundPitch;
          }
          if (isDrifting)
          {
              if (!tireScreechSound.isPlaying)
              {
                  tireScreechSound.Play();
              }
          }
          else
          {
              tireScreechSound.Stop();
          }
    }

    private void Sensors()
    {
        if (Crash)
        {
            drift.color = Color.red;
            scoreFL.color = Color.red;
            scoreFR.color = Color.red;
            scoreRL.color = Color.red;
            scoreRR.color = Color.red;
        }
        else
        {
            scoreFL.color = Color.yellow;
            scoreFR.color = Color.yellow;
            scoreRL.color = Color.yellow;
            scoreRR.color = Color.yellow;
        }

        Vector3 sensorStartPos = frontSensor.position;
        Vector3 sensorStartPosRear = rearSensor.position;
        if (Physics.Raycast(sensorStartPos,Quaternion.AngleAxis(-sensorsAngle, frontSensor.up) * frontSensor.right, out RaycastHit hit, sensorLength) && isDrifting)
        {
            Debug.DrawLine(sensorStartPos, hit.point);
            line.SetPosition(0, sensorStartPos);
            line.SetPosition(1, hit.point);
            var length = (sensorStartPos - hit.point).magnitude;
            if (!Crash)
            {
                pointsFR += 1;
            }
            scoreFR.text = " + " + pointsFR;
            if (length < 5)
            {
                SensorsMat.SetColor("_EmissionColor", Color.Lerp(Color.red, Color.green, length / 5.2f));
            }
        }
        else
        {
            scoreFR.text = "";
            if (!Crash)
            {
                driftpoints += pointsFR;
                totalpoints += pointsFR;
            }
            pointsFR = 0;
            line.SetPosition(0, sensorStartPos);
            line.SetPosition(1, sensorStartPos);
        }
        if (Physics.Raycast(sensorStartPos, Quaternion.AngleAxis(sensorsAngle, frontSensor.up) * -frontSensor.right, out hit, sensorLength) && isDrifting)
        {
            Debug.DrawLine(sensorStartPos, hit.point);
            line2.SetPosition(0, sensorStartPos);
            line2.SetPosition(1, hit.point);
            var length = (sensorStartPos - hit.point).magnitude;
            if (!Crash)
            {
                pointsFL += 1;
            }
            scoreFL.text = " + " + pointsFL;
            if (length < 5)
            {
                SensorsMat2.SetColor("_EmissionColor", Color.Lerp(Color.red, Color.green, length/5.2f));
            }
        }
        else
        {
            scoreFL.text = "";
            if (!Crash)
            {
                driftpoints += pointsFL;
                totalpoints += pointsFL;
            }
            pointsFL = 0;
            line2.SetPosition(0, sensorStartPos);
            line2.SetPosition(1, sensorStartPos);
        }

        if (Physics.Raycast(sensorStartPosRear, Quaternion.AngleAxis(sensorsAngle, frontSensor.up) * rearSensor.right, out hit, sensorLength) && isDrifting)
        {
            Debug.DrawLine(sensorStartPosRear, hit.point);
            line3.SetPosition(0, sensorStartPosRear);
            line3.SetPosition(1, hit.point);
            var length = (sensorStartPosRear - hit.point).magnitude;
            if (!Crash)
            {
                pointsRR += 1;
            }
            scoreRR.text = " + " + pointsRR;
            if (length < 5)
            {
                SensorsMat3.SetColor("_EmissionColor", Color.Lerp(Color.red, Color.green, length/5.2f));
            }
        }
        else
        {
            scoreRR.text = "";
            if (!Crash)
            {
                driftpoints += pointsRR;
                totalpoints += pointsRR;
            }
            pointsRR = 0;
            line3.SetPosition(0, sensorStartPos);
            line3.SetPosition(1, sensorStartPos);
        }
        if (Physics.Raycast(sensorStartPosRear, Quaternion.AngleAxis(-sensorsAngle, frontSensor.up) * -rearSensor.right, out hit, sensorLength) && isDrifting)
        {
            Debug.DrawLine(sensorStartPosRear, hit.point);
            line4.SetPosition(0, sensorStartPosRear);
            line4.SetPosition(1, hit.point);
            var length = (sensorStartPosRear - hit.point).magnitude;
            if (!Crash)
            {
                pointsRL += 1;
            }
            scoreRL.text = " + " + pointsRL;
            if (length < 5)
            {
                SensorsMat4.SetColor("_EmissionColor", Color.Lerp(Color.red, Color.green, length/5.2f));
            }
        }
        else
        {
            scoreRL.text = "";
            if (!Crash)
            {
                driftpoints += pointsRL;
                totalpoints += pointsRL;
            }
            pointsRL = 0;
            line4.SetPosition(0, sensorStartPos);
            line4.SetPosition(1, sensorStartPos);
        }
    }

    private void DriftPoints()
    {
        totalDrift.text = totalpoints.ToString();
        if (isDrifting)
        {
            driftMenu.SetActive(true);
            if (!Crash)
            {
                driftpoints += (1 * driftMultiplierFloat);
                drift.color = Color.white;
                currentTime = MaxTime;
                totalpoints += (1 * driftMultiplierFloat);
            }
            else if (Crash)
            {
                currentTime -= 1 * Time.deltaTime;
            }
            drift.text = "+ " + driftpoints.ToString();

            if (driftpoints > 2000 && driftpoints < 3999)
            {
                driftMultiplierFloat = 2;
            }
            else if (driftpoints > 4000)
            {
                driftMultiplierFloat = 3;
            }

            timerImage.color = Color.yellow;
        }
        else
        {
            currentTime -= 1 * Time.deltaTime;
        }

        if (timerImage.fillAmount == 0)
        {
            if (driftpoints > bestpoints)
            {
                if (!Crash)
                {
                    bestpoints = driftpoints;
                }
                bestDrift.text = bestpoints.ToString();
            }
            driftMenu.SetActive(false);
            driftMultiplierFloat = 1;
            Crash = false;
        }
        driftMultiplierText.text = driftMultiplierFloat + "x";
        timerImage.color = Color.Lerp(Color.red, Color.yellow, currentTime / MaxTime);
        timerImage.fillAmount = currentTime / MaxTime;
    }

    private void RpmMeter()
    {
        gearUI.text = gear.ToString();
        if (carSpeed > 220 && carSpeed < 250 && direction)
        {
            gear = 5;
            RPMs = (1369 / 30) * carSpeed - (13225 / 3);
            gearMultiplier = 11f;

        }
        else if (carSpeed > 140 && carSpeed < 220 && direction)
        {
            gear = 4;
            RPMs = (1703 / 80) * carSpeed + (9267 / 4);
            gearMultiplier = 18f;
        }
        else if (carSpeed > 80 && carSpeed < 140 && direction)
        {
            gear = 3;
            RPMs = (100 * carSpeed + 7000) / 3;
            gearMultiplier = 17f;
        }
        else if (carSpeed > 40 && carSpeed < 80 && direction)
        {
            gear = 2;
            RPMs = (125 * carSpeed + 4000) / 2;
            gearMultiplier = 20f;
            zryw = false;
        }
        else if (carSpeed < 40 && !Input.GetKey(KeyCode.Space) && !Input.GetKey(KeyCode.S))
        {
            gear = 1;

            if (zryw)
            {
                gearMultiplier = 40f;
                RPMs = 50 * carSpeed + 5000;
                if (AWD)
                {
                    RLWParticleSystem.Play();
                    RRWParticleSystem.Play();
                    FLWParticleSystem.Play();
                    FRWParticleSystem.Play();
                }
                else if (FWD)
                {
                    FLWParticleSystem.Play();
                    FRWParticleSystem.Play();
                }
                else if (RWD)
                {
                    RLWParticleSystem.Play();
                    RRWParticleSystem.Play();
                }
                if (!tireScreechSound.isPlaying)
                {
                    tireScreechSound.Play();
                }
            }
            else
            {
                gearMultiplier = 25f;
                RPMs = (315 / 2) * carSpeed + 700;
                RLWParticleSystem.Stop();
                RRWParticleSystem.Stop();
                FLWParticleSystem.Stop();
                FRWParticleSystem.Stop();
                tireScreechSound.Stop();
            }
        }
        if (!Input.GetKey(KeyCode.W))
        {
            zryw = false;
        }
        if (!direction)
        {
            gearUI.text = "R";
            RPMs = (315 / 2) * carSpeed + 700;
            if (Mathf.Abs(Mathf.RoundToInt(carSpeed)) < maxReverseSpeed)
            {
                direction = false;
                if (AWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = (accelerationMultiplier) * throttleAxis * 20f;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = (accelerationMultiplier) * throttleAxis * 20f;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = (accelerationMultiplier) * throttleAxis * 20f;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = (accelerationMultiplier) * throttleAxis * 20f;
                }
                else if (FWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = (accelerationMultiplier) * throttleAxis * 20f;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = (accelerationMultiplier) * throttleAxis * 20f;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = 0;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = 0;
                }
                else if (RWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = 0;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = 0;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = (accelerationMultiplier) * throttleAxis * 20f;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = (accelerationMultiplier) * throttleAxis * 20f;
                }
            }
            else
            {
                frontLeftCollider.motorTorque = 0;
                frontRightCollider.motorTorque = 0;
                rearLeftCollider.motorTorque = 0;
                rearRightCollider.motorTorque = 0;
            }
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S) && carSpeed < 5 && RWD)
        {

            RPMs += 5583.3f * (Time.deltaTime / 4);
            if (RPMs > 7000)
            {
                RPMs = 6700;
            }
            if (RPMs > 5800)
            {
                zryw = true;
            }
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.Space) && carSpeed < 5)
        {

            RPMs += 5583.3f * (Time.deltaTime / 4);
            if (RPMs > 7000)
            {
                RPMs = 6700;
            }
            if (RPMs > 5800)
            {
                zryw = true;
            }
        }
        else if (!Input.GetKey(KeyCode.W) && carSpeed < 5)
        {
            RPMs -= 1583.3f * Time.deltaTime;
            if (RPMs < 700)
            {
                RPMs = 700;
            }
        }
        arrow.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(ZERO_Rotation_Angle, MAX_Rotation_Angle, RPMs / 7000));
    }

    public void TurnLeft()
    {
        steeringAxis -= (Time.deltaTime * 10f * steeringSpeed);
        if (steeringAxis < -1f)
        {
            steeringAxis = -1f;
        }
        var steeringAngle = steeringAxis * maxSteeringAngle;
        frontLeftCollider.steerAngle = Mathf.Lerp(frontLeftCollider.steerAngle, steeringAngle, steeringSpeed);
        frontRightCollider.steerAngle = Mathf.Lerp(frontRightCollider.steerAngle, steeringAngle, steeringSpeed);
    }

    public void TurnRight()
    {
        steeringAxis += (Time.deltaTime * 10f * steeringSpeed);
        if (steeringAxis > 1f)
        {
            steeringAxis = 1f;
        }
        var steeringAngle = steeringAxis * maxSteeringAngle;
        frontLeftCollider.steerAngle = Mathf.Lerp(frontLeftCollider.steerAngle, steeringAngle, steeringSpeed);
        frontRightCollider.steerAngle = Mathf.Lerp(frontRightCollider.steerAngle, steeringAngle, steeringSpeed);
    }

    public void ResetSteeringAngle()
    {
        if (steeringAxis < 0f)
        {
            steeringAxis += (Time.deltaTime * 10f * steeringSpeed);
        }
        else if (steeringAxis > 0f)
        {
            steeringAxis -= (Time.deltaTime * 10f * steeringSpeed);
        }
        if (Mathf.Abs(frontLeftCollider.steerAngle) < 1f)
        {
            steeringAxis = 0f;
        }
        var steeringAngle = steeringAxis * maxSteeringAngle;
        frontLeftCollider.steerAngle = Mathf.Lerp(frontLeftCollider.steerAngle, steeringAngle, steeringSpeed);
        frontRightCollider.steerAngle = Mathf.Lerp(frontRightCollider.steerAngle, steeringAngle, steeringSpeed);
    }

    void AnimateWheelMeshes()
    {
        frontLeftCollider.GetWorldPose(out Vector3 FLWPosition, out Quaternion FLWRotation);
        frontLeftMesh.transform.SetPositionAndRotation(FLWPosition, FLWRotation);

        frontRightCollider.GetWorldPose(out Vector3 FRWPosition, out Quaternion FRWRotation);
        frontRightMesh.transform.SetPositionAndRotation(FRWPosition, FRWRotation);

        rearLeftCollider.GetWorldPose(out Vector3 RLWPosition, out Quaternion RLWRotation);
        rearLeftMesh.transform.SetPositionAndRotation(RLWPosition, RLWRotation);

        rearRightCollider.GetWorldPose(out Vector3 RRWPosition, out Quaternion RRWRotation);
        rearRightMesh.transform.SetPositionAndRotation(RRWPosition, RRWRotation);
    }

    public void GoForward()
    {
        if (Mathf.Abs(localVelocityX) > 5f)
        {
            isDrifting = true;
            DriftCarPS();
        }
        else
        {
            isDrifting = false;
            DriftCarPS();
        }
        throttleAxis += (Time.deltaTime * 3f);
        if (throttleAxis > 1f)
        {
            throttleAxis = 1f;
        }
        if (localVelocityZ < -1f)
        {
            Brakes();
        }
        else
        {
            direction = true;
            if (Mathf.RoundToInt(carSpeed) < maxSpeed)
            {
                if (AWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = (accelerationMultiplier * gearMultiplier * nitroBoost) * throttleAxis;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = (accelerationMultiplier * gearMultiplier * nitroBoost) * throttleAxis;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = (accelerationMultiplier * gearMultiplier * nitroBoost) * throttleAxis;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = (accelerationMultiplier * gearMultiplier * nitroBoost) * throttleAxis;
                }
                else if (FWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = (accelerationMultiplier * gearMultiplier * nitroBoost) * throttleAxis;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = (accelerationMultiplier * gearMultiplier * nitroBoost) * throttleAxis;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = 0;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = 0;
                }
                else if (RWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = 0;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = 0;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = (accelerationMultiplier * gearMultiplier * nitroBoost) * throttleAxis;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = (accelerationMultiplier * gearMultiplier * nitroBoost) * throttleAxis;
                }

            }
            else
            {
                frontLeftCollider.motorTorque = 0;
                frontRightCollider.motorTorque = 0;
                rearLeftCollider.motorTorque = 0;
                rearRightCollider.motorTorque = 0;
            }
        }
    }

    public void GoReverse()
    {
        if (Mathf.Abs(localVelocityX) > 2.5f)
        {
            isDrifting = true;
            DriftCarPS();
        }
        else
        {
            isDrifting = false;
            DriftCarPS();
        }
        throttleAxis -= (Time.deltaTime * 3f);
        if (throttleAxis < -1f)
        {
            throttleAxis = -1f;
        }
        if (localVelocityZ > 1f)
        {
            Brakes();
        }
        else
        {
            if (Mathf.Abs(Mathf.RoundToInt(carSpeed)) < maxReverseSpeed)
            {
                direction = false;
                if (AWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = (accelerationMultiplier * 20f) * throttleAxis;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = (accelerationMultiplier * 20f) * throttleAxis;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = (accelerationMultiplier * 20f) * throttleAxis;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = (accelerationMultiplier * 20f) * throttleAxis;
                }
                else if (FWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = (accelerationMultiplier * 20f) * throttleAxis;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = (accelerationMultiplier * 20f) * throttleAxis;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = 0;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = 0;
                }
                else if (RWD)
                {
                    frontLeftCollider.brakeTorque = 0;
                    frontLeftCollider.motorTorque = 0;
                    frontRightCollider.brakeTorque = 0;
                    frontRightCollider.motorTorque = 0;
                    rearLeftCollider.brakeTorque = 0;
                    rearLeftCollider.motorTorque = (accelerationMultiplier * 20f) * throttleAxis;
                    rearRightCollider.brakeTorque = 0;
                    rearRightCollider.motorTorque = (accelerationMultiplier * 20f) * throttleAxis;
                }
            }
            else
            {
                frontLeftCollider.motorTorque = 0;
                frontRightCollider.motorTorque = 0;
                rearLeftCollider.motorTorque = 0;
                rearRightCollider.motorTorque = 0;
            }
        }
    }


    private void DecelerateCar()
    {
        if (Mathf.Abs(localVelocityX) > 2.5f)
        {
            isDrifting = true;
            DriftCarPS();
        }
        else
        {
            isDrifting = false;
            DriftCarPS();
        }
        if (throttleAxis != 0f)
        {
            if (throttleAxis > 0f)
            {
                throttleAxis -= (Time.deltaTime * 10f);
            }
            else if (throttleAxis < 0f)
            {
                throttleAxis += (Time.deltaTime * 10f);
            }
            if (Mathf.Abs(throttleAxis) < 0.15f)
            {
                throttleAxis = 0f;
            }
        }
        carRigidbody.velocity *= (1f / (1f + (0.005f * decelerationMultiplier)));
        frontLeftCollider.motorTorque = 0;
        frontRightCollider.motorTorque = 0;
        rearLeftCollider.motorTorque = 0;
        rearRightCollider.motorTorque = 0;
        if (carRigidbody.velocity.magnitude < 0.25f)
        {
            carRigidbody.velocity = Vector3.zero;
            CancelInvoke("DecelerateCar");
        }

    }

    private void Handbrake()
    {
        CancelInvoke("RecoverTraction");

        driftingAxis += (Time.deltaTime);
        float secureStartingPoint = driftingAxis * FLWextremumSlip * handbrakeDriftMultiplier;

        if (secureStartingPoint < FLWextremumSlip)
        {
            driftingAxis = FLWextremumSlip / (FLWextremumSlip * handbrakeDriftMultiplier);
        }
        if (driftingAxis > 1f)
        {
            driftingAxis = 1f;
        }

        isDrifting = Mathf.Abs(localVelocityX) > 2.5f;

        if (driftingAxis < 1f)
        {
            RLwheelFriction.extremumSlip = RLWextremumSlip * handbrakeDriftMultiplier * driftingAxis;
            rearLeftCollider.sidewaysFriction = RLwheelFriction;

            RRwheelFriction.extremumSlip = RRWextremumSlip * handbrakeDriftMultiplier * driftingAxis;
            rearRightCollider.sidewaysFriction = RRwheelFriction;
        }
        DriftCarPS();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Crash = true;
    }

    private void CarSpeedUI()
    {
        float absoluteCarSpeed = Mathf.Abs(carSpeed);
        carSpeedText.text = Mathf.RoundToInt(absoluteCarSpeed).ToString();
    }

    private void ThrottleOff()
    {
        frontLeftCollider.motorTorque = 0;
        frontRightCollider.motorTorque = 0;
        rearLeftCollider.motorTorque = 0;
        rearRightCollider.motorTorque = 0;
    }

    private void Brakes()
    {
        frontLeftCollider.brakeTorque = brakeForce;
        frontRightCollider.brakeTorque = brakeForce;
        rearLeftCollider.brakeTorque = brakeForce;
        rearRightCollider.brakeTorque = brakeForce;
    }

    private void ExhaFire()
    {
        if (actualGear > gear || actualGear < gear)
        {
            leftExha.Play();
            rightExha.Play();
            actualGear = gear;
        }
        else
        {
            leftExha.Stop();
            rightExha.Stop();
        }
    }

    private void DriftCarPS()
    {
        RLWTireSkid.emitting = isDrifting;
        RRWTireSkid.emitting = isDrifting;
        FLWTireSkid.emitting = isDrifting;
        FRWTireSkid.emitting = isDrifting;
        if (isDrifting)
        {
            if (AWD)
            {
                RLWParticleSystem.Play();
                RRWParticleSystem.Play();
                FLWParticleSystem.Play();
                FRWParticleSystem.Play();
            }
            else if (FWD)
            {
                FLWParticleSystem.Play();
                FRWParticleSystem.Play();
                RLWParticleSystem.Play();
                RRWParticleSystem.Play();
            }
            else if (RWD)
            {
                RLWParticleSystem.Play();
                RRWParticleSystem.Play();
            }
        }
        else
        {
            RLWParticleSystem.Stop();
            RRWParticleSystem.Stop();
            FLWParticleSystem.Stop();
            FRWParticleSystem.Stop();
        }
    }

    private void RecoverTraction()
    {
        driftingAxis -= (Time.deltaTime / 1.5f);
        if (driftingAxis < 0f)
        {
            driftingAxis = 0f;
        }

        if (RLwheelFriction.extremumSlip > RLWextremumSlip)
        {
            RLwheelFriction.extremumSlip = RLWextremumSlip * handbrakeDriftMultiplier * driftingAxis;
            rearLeftCollider.sidewaysFriction = RLwheelFriction;

            RRwheelFriction.extremumSlip = RRWextremumSlip * handbrakeDriftMultiplier * driftingAxis;
            rearRightCollider.sidewaysFriction = RRwheelFriction;

            Invoke(nameof(RecoverTraction), Time.deltaTime);

        }
        else if (RLwheelFriction.extremumSlip < RLWextremumSlip)
        {
            RLwheelFriction.extremumSlip = RLWextremumSlip;
            rearLeftCollider.sidewaysFriction = RLwheelFriction;

            RRwheelFriction.extremumSlip = RRWextremumSlip;
            rearRightCollider.sidewaysFriction = RRwheelFriction;

            driftingAxis = 0f;
        }
    }

    private void Nitro()
    {
        if (isDrifting)
        {
            nitroAmmount += 1;
        }
        if (nitroAmmount > 10000)
        {
            nitroAmmount = 10000;
        }
        nitroIcon.fillAmount = (nitroAmmount / 10000);
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && nitroAmmount > 1)
        {
            nitroAmmount -= 10;
            nitroBoost = 1.5f;
            nitroMeneger.SetActive(true);
            nitroLeft.Play();
            nitroRight.Play();
        }
        else
        {
            nitroBoost = 1f;
            nitroMeneger.SetActive(false);
            nitroLeft.Stop();
            nitroRight.Stop();
        }
    }

    private void Lights()
    {
        BrakesLights.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", direction && Input.GetKey(KeyCode.S) || !direction && Input.GetKey(KeyCode.W) ? Color.red * 10f : Color.black);
        ReverseLights.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", direction ? Color.black : Color.white * 5f);
    }

    private void Suspension()
    {
        FLBrakes.transform.position = frontLeftMesh.transform.position;
        FRBrakes.transform.position = frontRightMesh.transform.position;
        RLBrakes.transform.position = rearLeftMesh.transform.position;
        RRBrakes.transform.position = rearRightMesh.transform.position;

        Quaternion newRotation = frontLeftMesh.transform.rotation;
        newRotation.x = 0f;
        newRotation.z = 0f;
        FLBrakes.transform.rotation = newRotation;
        FRBrakes.transform.rotation = newRotation;
    }

    private void SetScoresTowardsPlayer()
    {
        score1.LookAt(cam);
        score2.LookAt(cam);
        score3.LookAt(cam);
        score4.LookAt(cam);
    }
}
