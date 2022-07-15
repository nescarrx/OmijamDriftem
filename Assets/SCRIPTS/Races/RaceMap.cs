using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceMap : MonoBehaviour
{
    public void Accept()
    {
        SceneManager.LoadScene("GARAGE");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Decline()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
