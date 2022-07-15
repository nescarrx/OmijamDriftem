using UnityEngine;

public class MenuEffects : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;

    public ParticleSystem car1smokeL;
    public ParticleSystem car1smokeR;
    public ParticleSystem car2smokeL;
    public ParticleSystem car2smokeR;
    public ParticleSystem car3smokeL;
    public ParticleSystem car3smokeR;
    void Start()
    {
        if (PlayerPrefs.GetInt("car") == 1)
        {
            car1.SetActive(true);
            car1smokeL.Play();
            car1smokeR.Play();
        }
        else if (PlayerPrefs.GetInt("car") == 2)
        {
            car2.SetActive(true);
            car2smokeL.Play();
            car2smokeR.Play();
        }
        else if (PlayerPrefs.GetInt("car") == 3)
        {
            car3.SetActive(true);
            car3smokeL.Play();
            car3smokeR.Play();
        }
    }
}
