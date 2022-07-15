using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform rotator;
    [SerializeField] private Transform car;

    protected Transform _XForm_Camera;
    protected Transform _XForm_Parent;

    protected Vector3 _LocalRotation;
    protected float _CameraDistance = 10f;

    readonly float MouseSensitivity = 4f;
    readonly float OrbitDampening = 10f;

    [SerializeField] private CarController carController;
    
    float carNitro;

    private Vector3 carposition;

    public float NitroAmmount => carNitro;
    void Start()
    {
        this._XForm_Camera = this.transform;
        this._XForm_Parent = this.transform.parent;
    }

    private void FixedUpdate()
    {
        carNitro = carController.NitroAmmount;
        carposition = car.position;
        carposition.y = car.position.y + 1f;
        rotator.position = carposition;
    }


    void LateUpdate()
    {
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            _LocalRotation.x += Input.GetAxis("Mouse X") * MouseSensitivity;
            _LocalRotation.y -= Input.GetAxis("Mouse Y") * MouseSensitivity;
            if (_LocalRotation.y < -5f)
                _LocalRotation.y = -5f;
            else if (_LocalRotation.y > 90f)
                _LocalRotation.y = 90f;
        }
        Quaternion QT = Quaternion.Euler(_LocalRotation.y, _LocalRotation.x, 0);
        this._XForm_Parent.rotation = Quaternion.Lerp(this._XForm_Parent.rotation, QT, Time.deltaTime * OrbitDampening);
    }
}