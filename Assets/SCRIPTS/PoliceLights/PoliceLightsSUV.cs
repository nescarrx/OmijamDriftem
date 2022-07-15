using System.Collections;
using UnityEngine;


public class PoliceLightsSUV : MonoBehaviour
{
    public Renderer Red_1S;
    public Renderer Red_2S;
    public Renderer Red_3S;
    public Renderer Red_4S;
    public Renderer Red_5S;
    public Renderer Red_6S;
    public Renderer Red_7S;
    public Renderer Red_8S;
    public Renderer Red_9S;
    public Renderer Blue_1S;
    public Renderer Blue_2S;
    public Renderer Blue_3S;
    public Renderer Blue_4S;
    public Renderer Blue_5S;
    public Renderer Blue_6S;
    public Renderer Blue_7S;
    public Renderer Blue_8S;
    public Renderer Blue_9S;

    void Start()
    {
        StartCoroutine(FlashingLights());
    }

    IEnumerator FlashingLights()
    {
        while (true)
        {
            Blue_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_4S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Red_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_4S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Red_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Red_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            yield return new WaitForSeconds(0.1f);
            Red_4S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_4S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            yield return new WaitForSeconds(0.1f);
            Red_4S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Blue_4S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Red_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Blue_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Red_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Red_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            yield return new WaitForSeconds(0.1f);
            Red_4S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_4S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            yield return new WaitForSeconds(0.1f);
            Red_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Blue_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Red_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Red_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Blue_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Red_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Red_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Blue_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            yield return new WaitForSeconds(0.1f);
            Red_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            yield return new WaitForSeconds(0.1f);
            Red_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Blue_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Red_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Red_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Blue_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Red_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Red_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red);
            Blue_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            Blue_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue);
            yield return new WaitForSeconds(0.1f);
            Red_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_5S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_3S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_2S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_6S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_8S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_7S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_9S.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
        }
    }
}
