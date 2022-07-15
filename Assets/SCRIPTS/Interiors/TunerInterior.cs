using UnityEngine;
using UnityEngine.SceneManagement;

public class TunerInterior : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Tuner");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
