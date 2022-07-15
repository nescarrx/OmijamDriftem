using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField] private Transform wrench;
    [SerializeField] private Transform spray;
    [SerializeField] private Transform garage;
    [SerializeField] private Transform timer;
    [SerializeField] private Transform car;


    private Vector3 tempPositionW;
    private Vector3 tempPositionS;
    private Vector3 tempPositionG;
    private Vector3 tempPositionT;

    // Start is called before the first frame update
    void Start()
    {
        tempPositionW = wrench.position;
        tempPositionS = spray.position;
        tempPositionG = garage.position;
        tempPositionT = timer.position;
    }

    // Update is called once per frame
    void Update()
    {
        wrench.LookAt(car);
        garage.LookAt(car);
        spray.LookAt(car);
        timer.LookAt(car);

        tempPositionG.y = Mathf.Sin(Time.realtimeSinceStartup * 1f) + 1f;
        tempPositionS.y = Mathf.Sin(Time.realtimeSinceStartup * 1f) + 1f;
        tempPositionW.y = Mathf.Sin(Time.realtimeSinceStartup * 1f) + 1f;
        tempPositionT.y = Mathf.Sin(Time.realtimeSinceStartup * 1f) + 1f;
        wrench.position = tempPositionW;
        spray.position = tempPositionS;
        garage.position = tempPositionG;
        timer.position = tempPositionT;

    }
}
