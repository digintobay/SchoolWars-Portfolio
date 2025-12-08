using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public Camera MainCamera;
    [Header("CameraList")]
    public Camera HaneulCamera;
    public Camera JiyunCamera;
    public Camera SeyeongCamera;
    public Camera JihyeCamera;
    public Camera SominCamera;
    [Header("UpBringingUI")]
    public GameObject Minimap;


    public void HaneulEvent()
    {
        AllCameraDown();
        HaneulCamera.enabled = true;
    }

    public void HaneulFinishedEvent()
    {
        MainCameraUp();
    }

    //지윤 이벤트

    public void JiyunEvent()
    {
        AllCameraDown();
        JiyunCamera.enabled = true;
    }

    public void JiyunFinishedEvent()
    {
        MainCameraUp();

    }

    //세영 이벤트

    public void SeyeongEvent()
    {
        AllCameraDown();
        SeyeongCamera.enabled = true;
    }

    public void SeyeongFinishedEvent()
    {
        MainCameraUp();

    }

    //지혜 이벤트

    public void JihyeEvent()
    {
        AllCameraDown();
        JihyeCamera.enabled = true;
    }

    public void JihyeFinishedEvent()
    {
        MainCameraUp();

    }

    //소민 이벤트


    public void SominEvent()
    {
        AllCameraDown();
        SominCamera.enabled = true;
    }

    public void SominFinishedEvent()
    {
        MainCameraUp();

    }

    //모든 카메라 종료

    public void AllCameraDown()
    {
        MainCamera.enabled = false;
        HaneulCamera.enabled = false;
        JiyunCamera.enabled = false;
        SeyeongCamera.enabled = false;
        JihyeCamera.enabled = false;
        SominCamera.enabled = false;
        Minimap.SetActive(false);

    }

    // 메인 카메라만 켜기

    public void MainCameraUp()
    {
        MainCamera.enabled = true;
        Minimap.SetActive(true);
        HaneulCamera.enabled = false;
        JiyunCamera.enabled = false;
        SeyeongCamera.enabled = false;
        JihyeCamera.enabled = false;
        SominCamera.enabled = false;

    }
}
