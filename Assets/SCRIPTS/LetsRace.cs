using UnityEngine;
using UnityEngine.SceneManagement;

public class LetsRace : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("RACE");
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
