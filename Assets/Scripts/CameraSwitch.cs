using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] GameObject Cam0;
    [SerializeField] GameObject Cam1;
    [SerializeField] GameObject Cam2;
    [SerializeField] GameObject Cam3;
    /*[SerializeField] GameObject Cam4;
    [SerializeField] GameObject Cam5;*/

    int CamNumb = 0;

    // Start is called before the first frame update
    void Start()
    {}

    // Update is called once per frame
    void Update()
    {
        ControlCamera(CamNumb);
        SwitchingCamOn();
        /*if (Input.GetKeyDown(KeyCode.C))
        {
            if (CamNumb == 5)
            {
                CamNumb = 0;
            }
            CamNumb++;
            ControlCamera(CamNumb);
            return;
        }*/
    }
    void ControlCamera(int CamNum)
    {
        if (CamNum == 0)
        {
            ResetCameras();
            Cam0.SetActive(true);
        }
        if (CamNum == 1)
        {
            ResetCameras();
            Cam1.SetActive(true);
        }
        if (CamNum == 2)
        {
            ResetCameras();
            Cam2.SetActive(true);
        }
        if (CamNum == 3)
        {
            ResetCameras();
            Cam3.SetActive(true);
        }
        /*if (CamNum == 4)
        {
            ResetCameras();
            Cam4.SetActive(true);
        }
        if (CamNum == 5)
        {
            ResetCameras();
            Cam5.SetActive(true);
        }*/
    }
    void ResetCameras()
    {
        Cam0.SetActive(false);
        Cam1.SetActive(false);
        Cam2.SetActive(false);
        Cam3.SetActive(false);
        /*Cam4.SetActive(false);
        Cam5.SetActive(false);*/
    }

    public void SwitchingCamOn()
    {
        if (GameManager.Instance.CamValue == 0)
        {
            CamNumb = 0;
        }
        if (GameManager.Instance.CamValue == 2)
        {
            CamNumb = 2;
        }
        if (GameManager.Instance.CamValue == 3)
        {
            CamNumb = 3;
        }
        if (GameManager.Instance.CamValue == 4)
        {
            CamNumb = 4;
        }
        if (GameManager.Instance.CamValue == 5)
        {
            CamNumb = 5;
        }
        if (GameManager.Instance.CamValue == 1)
        {
            CamNumb = 1;
        }
    }

}
