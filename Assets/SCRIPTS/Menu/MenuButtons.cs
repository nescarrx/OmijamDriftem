using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void Wyjdz()
    {
        Application.Quit();
    }
    public void MapaGlowna()
    {
        SceneManager.LoadScene("GARAGE");
    }
}
