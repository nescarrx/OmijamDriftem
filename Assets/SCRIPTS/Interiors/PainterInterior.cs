using UnityEngine;
using UnityEngine.SceneManagement;

public class PainterInterior : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Painter");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
