using System.Collections;
using UnityEngine;


public class PoliceLights : MonoBehaviour
{
    public Renderer Red_1;
    public Renderer Red_2;
    public Renderer Red_3;
    public Renderer Red_4;
    public Renderer Blue_1;
    public Renderer Blue_2;
    public Renderer Blue_3;
    public Renderer Blue_4;

    void Start()
    {
        StartCoroutine(RearFlashingLights());
        StartCoroutine(FrontFlashingLights());
    }

    IEnumerator RearFlashingLights()
    {
        while (true)
        {
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
                    yield return new WaitForSeconds(0.1f);
            Red_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
            Red_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
                yield return new WaitForSeconds(0.1f);
            Red_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
                    yield return new WaitForSeconds(0.1f);
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
                    yield return new WaitForSeconds(0.1f);
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
            //secondPhase
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
                    yield return new WaitForSeconds(0.1f);
            Blue_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
                    yield return new WaitForSeconds(0.1f);
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
                    yield return new WaitForSeconds(0.1f);
            Blue_1.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_4.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                    yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator FrontFlashingLights()
    {
        while (true)
        {
            Blue_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Blue_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
                yield return new WaitForSeconds(0.1f);
            Red_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                yield return new WaitForSeconds(0.1f);
            Red_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
            Red_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.red * 50f);
                yield return new WaitForSeconds(0.1f);
            Red_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Red_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                yield return new WaitForSeconds(0.1f);
            Blue_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
                yield return new WaitForSeconds(0.1f);
            Blue_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                yield return new WaitForSeconds(0.1f);
            Blue_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
            Blue_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.blue * 50f);
                yield return new WaitForSeconds(0.1f);
            Blue_3.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
            Blue_2.GetComponent<MeshRenderer>().material.SetColor("_EmissionColor", Color.black);
                yield return new WaitForSeconds(0.1f);
        }
    }
}
