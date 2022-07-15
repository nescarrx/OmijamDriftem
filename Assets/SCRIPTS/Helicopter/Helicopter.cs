using UnityEngine;

public class Helicopter : MonoBehaviour
{
    [SerializeField] private Transform helicopter;
    [SerializeField] private Transform car;
    [SerializeField] private Transform lights;

    private void Update()
    {
        lights.LookAt(car);
        helicopter.LookAt(car);
        Vector3 carpos = car.position;
        carpos.y = 80f;
        helicopter.position = Vector3.MoveTowards(helicopter.position, carpos, 0.1f);
    }
}
