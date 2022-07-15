using UnityEngine;

public class Reset : MonoBehaviour
{
    [SerializeField] private Transform car;
    [SerializeField] private Transform Checkpoint;

    private float currentT = 1f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            currentT += 1f * Time.deltaTime;
            if(currentT > 5f)
            {
                car.position = Checkpoint.position;
                car.rotation = Checkpoint.rotation;
                currentT = 5f;
            }
        }
        else
        {
            currentT = 1f;
        }
    }
}