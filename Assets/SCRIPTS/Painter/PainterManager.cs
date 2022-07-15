using UnityEngine;
using UnityEngine.SceneManagement;

public class PainterManager : MonoBehaviour
{
    public GameObject bodyKits;
    public GameObject brakes;
    public GameObject body;
    public GameObject exhaust;
    public GameObject Hood;
    public GameObject RoofScoop;
    public GameObject lights;
    public GameObject mirrors;
    public GameObject neons;
    public GameObject Roof;
    public GameObject smoke;
    public GameObject spojler;
    public GameObject Trunk;
    public GameObject wheels;
    public GameObject windows;
    public GameObject Speedometer;
    public GameObject Nitro;
    public GameObject Velocity;
    public GameObject Arrow;

    public Transform cam;
    public Transform camBrakes;
    public Transform camMain;
    public Transform trunkCam;
    public Transform roofCam;
    public Transform wheelsCam;
    public Transform neonCam;
    public Transform bodykitsCam;
    public Transform exhaustCam;

    public GameObject MainWindow;
    public GameObject SpecialsWindow;
    public GameObject BodyWindow;
    public GameObject AddonsWindow;
    public GameObject MeterWindow;
    public GameObject SpeedometerWindow;
    public GameObject NeonsWindow;
    public GameObject NeonsKit;

    public Material carColor;
    public Material trunkColor2;
    public Material hoodColor2;
    public Material roofColor2;

    public Trunk trunkScript;
    public Hood hoodScript;
    public Roof roofScript;

    public ParticleSystem smokeShow;
    void Start()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene("RACE");
        }
        if (trunkScript.isBlackT)
        {
            trunkColor2.color = Color.black;
        }
        else if (!trunkScript.isBlackT)
        {
            trunkColor2.color = carColor.color;
        }
        if (roofScript.isBlackR)
        {
            roofColor2.color = Color.black;
        }
        else if (!roofScript.isBlackR)
        {
            roofColor2.color = carColor.color;
        }
        if (hoodScript.isBlackH)
        {
            hoodColor2.color = Color.black;
        }
        else if (!hoodScript.isBlackH)
        {
            hoodColor2.color = carColor.color;
        }

        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            MeterWindow.SetActive(false);
            SpecialsWindow.SetActive(false);
            AddonsWindow.SetActive(false);
            BodyWindow.SetActive(false);
            MainWindow.SetActive(true);
            cam.position = camMain.position;
            cam.rotation = camMain.rotation;
        }

        if (MeterWindow.activeInHierarchy)
        {
            SpeedometerWindow.SetActive(true);
        }
        else
        {
            SpeedometerWindow.SetActive(false);
        }



    }

    public void BodyMenu()
    {
        MainWindow.SetActive(false);
        BodyWindow.SetActive(true);
    }

    public void AddonsMenu()
    {
        MainWindow.SetActive(false);
        AddonsWindow.SetActive(true);
    }

    public void LightsMenu()
    {
        MainWindow.SetActive(false);
        SpecialsWindow.SetActive(true);
    }

    public void MetersMenu()
    {
        MainWindow.SetActive(false);
        MeterWindow.SetActive(true);
    }

    public void MainMenu()
    {
        MeterWindow.SetActive(false);
        SpecialsWindow.SetActive(false);
        AddonsWindow.SetActive(false);
        BodyWindow.SetActive(false);
        MainWindow.SetActive(true);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
    }

    public void exhaustColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(true);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = exhaustCam.position;
        cam.rotation = exhaustCam.rotation;
        smokeShow.Stop();
    }

    public void roofScoopColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(true);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(true);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }

    public void Body()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(true);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
    }
    public void Mirrors()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(true);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }
    public void Brakes()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(true);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camBrakes.position;
        cam.rotation = camBrakes.rotation;
        smokeShow.Stop();
    }
    public void bodyKit()
    {
        bodyKits.SetActive(true);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = bodykitsCam.position;
        cam.rotation = bodykitsCam.rotation;
        smokeShow.Stop();
    }
    public void Lights()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(true);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }
    public void Smoke()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(true);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Play();
    }

    public void Speedo()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(true);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }

    public void Nitrous()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(true);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }

    public void Velo()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(true);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }

    public void Arrows()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(true);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }

    public void wheelsColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(true);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = wheelsCam.position;
        cam.rotation = wheelsCam.rotation;
        smokeShow.Stop();
    }

    public void windowsColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(true);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }

    public void spoilerColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(true);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = trunkCam.position;
        cam.rotation = trunkCam.rotation;
        smokeShow.Stop();
    }

    public void neonsColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = wheelsCam.position;
        cam.rotation = wheelsCam.rotation;
        smokeShow.Stop();

        if (!NeonsKit.activeInHierarchy)
        {
            NeonsWindow.SetActive(true);
        }
        else
        {
            neons.SetActive(true);
            NeonsWindow.SetActive(false);
        }
    }

    public void hoodColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(true);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = camMain.position;
        cam.rotation = camMain.rotation;
        smokeShow.Stop();
    }

    public void roofColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(true);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(false);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = roofCam.position;
        cam.rotation = roofCam.rotation;
        smokeShow.Stop();
    }

    public void trunkColor()
    {
        bodyKits.SetActive(false);
        brakes.SetActive(false);
        body.SetActive(false);
        exhaust.SetActive(false);
        Hood.SetActive(false);
        RoofScoop.SetActive(false);
        lights.SetActive(false);
        mirrors.SetActive(false);
        neons.SetActive(false);
        Roof.SetActive(false);
        smoke.SetActive(false);
        spojler.SetActive(false);
        Trunk.SetActive(true);
        wheels.SetActive(false);
        windows.SetActive(false);
        Speedometer.SetActive(false);
        Nitro.SetActive(false);
        Velocity.SetActive(false);
        Arrow.SetActive(false);
        cam.position = trunkCam.position;
        cam.rotation = trunkCam.rotation;
        smokeShow.Stop();
    }

    //Neons window options:

    public void buyNeons()
    {
        NeonsKit.SetActive(true);
        NeonsWindow.SetActive(false);
        neons.SetActive(true);
        PlayerPrefs.SetInt("neon", 1);
    }
    public void DeclineNeons()
    {
        NeonsWindow.SetActive(false);
        PlayerPrefs.SetInt("neon", 0);
    }
}
