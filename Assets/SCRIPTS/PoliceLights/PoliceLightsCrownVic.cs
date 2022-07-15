using System.Collections;
using UnityEngine;


public class PoliceLightsCrownVic : MonoBehaviour
{
    public Renderer Red_1CV;
    public Renderer Red_2CV;
    public Renderer Red_3CV;
    public Renderer Red_4CV;
    public Renderer Red_5CV;
    public Renderer Red_6CV;
    public Renderer Red_7CV;
    public Renderer Red_8CV;
    public Renderer Red_9CV;
    public Renderer Red_10CV;
    public Renderer Blue_1CV;
    public Renderer Blue_2CV;
    public Renderer Blue_3CV;
    public Renderer Blue_4CV;
    public Renderer Blue_5CV;
    public Renderer Blue_6CV;
    public Renderer Blue_7CV;
    public Renderer Blue_8CV;
    public Renderer Blue_9CV;
    public Renderer Blue_10CV;

    void Start()
    {
        StartCoroutine(FlashingLights());
    }

    IEnumerator FlashingLights()
    {
        while (true)
        {
            Blue_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_4CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_4CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            yield return new WaitForSeconds(0.1f);
            Red_4CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_4CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            yield return new WaitForSeconds(0.1f);
            Red_4CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_4CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            yield return new WaitForSeconds(0.1f);
            Red_4CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_4CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            yield return new WaitForSeconds(0.1f);
            Red_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            yield return new WaitForSeconds(0.1f);
            Red_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            yield return new WaitForSeconds(0.1f);
            Red_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            yield return new WaitForSeconds(0.1f);
            Red_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_5CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_3CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_2CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_6CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_8CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_7CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_9CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_10CV.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
        }
    }
}
