using UnityEngine;
using UnityEngine.SceneManagement;

public class ESC : MonoBehaviour
{
    [SerializeField] private GameObject Main;
    [SerializeField] private GameObject sounds;
    [SerializeField] private GameObject Escape;
    [SerializeField] private Behaviour Car;
    void Start()
    {
        Escape.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            PausedGame();
        }
    }
    public void PausedGame()
    {
        Main.SetActive(false);
        Escape.SetActive(true);
        Time.timeScale = 0f;
        Car.enabled = false;
        sounds.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void ResumedGame()
    {
        Main.SetActive(true);
        Escape.SetActive(false);
        Time.timeScale = 1f;
        Car.enabled = true;
        sounds.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void LeaveGame()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
