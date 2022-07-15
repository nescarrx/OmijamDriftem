using UnityEngine;

public class LastPosition : MonoBehaviour
{
    [SerializeField] private Transform car;
    private float x, y, z;
    void Start()
    {
        Load();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            Save();
        }
    }

    public void Save()
    {
        x = car.position.x;
        y = car.position.y;
        z = car.position.z;

        PlayerPrefs.SetFloat("x", x);
        PlayerPrefs.SetFloat("y", y);
        PlayerPrefs.SetFloat("z", z);
    }

    public void Load()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(x, y, z);
        car.position = LoadPosition;
    }
}
