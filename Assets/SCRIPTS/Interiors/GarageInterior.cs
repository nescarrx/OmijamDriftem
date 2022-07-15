using UnityEngine;
using UnityEngine.SceneManagement;

public class GarageInterior : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("GARAGE");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
