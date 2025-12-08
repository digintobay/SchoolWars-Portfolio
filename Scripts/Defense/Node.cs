using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    private Color startColor;
    public Vector3 positionOffset;

    private GameObject turret;

    public LayerMask playerLayerMask; // 플레이어 확인용 레이어마스크
    public Camera mainCamera;

    private Renderer rend;

    private float normalAlpha = 0.0f;
    private float hoverAlpha = 1.0f;

    float currentTime = 0;
    float currentTime2 = 0;
    float fadeTime = 2;

    public static bool buildsomin;
    public static bool buildjihye;
    public static bool buildhaneul;
    public static bool buildjiyun;
    public static bool buildseyeong;

    private void Awake()
    {
        buildsomin = false;
        buildjihye = false;
        buildhaneul = false;
        buildjiyun = false;
        buildseyeong = false;
    }

    private void Start()
    {
        



        mainCamera = Camera.main;

        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        StartCoroutine(StartNodes());

        playerLayerMask = LayerMask.GetMask("Player");
    }

    private void OnMouseDown()
    {
        if (UnderMouse()) // 오브젝트가 해당 위치에 존재
        {
            Debug.Log("못 짓습니다");

            return;
        }
        else if (!OneStageWaveSpawner.dragnow) //정비 시간에는 설치 불가
        {
            Debug.Log("정비 중입니다");
            return;
        }

        GameObject turretToBuild = BuildMaster.Instance.GetTurretToBuild();

        if (ChangeBuild.Bomb == true && Money.money >= 10)
        {
            Money.money -= 10;
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

        }

        if (ChangeBuild.Turret == true && Money.money >= 15)
        {
            Money.money -= 15;
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
        }

        if (ChangeBuild.Kimsomin == true && Money.money >= 5 && buildsomin == false)
        {
            Money.money -= 5;
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            buildsomin = true;
        }

        if (ChangeBuild.Parkjihye == true && Money.money >= 8 && buildjihye == false)
        {
            Money.money -= 8;
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            buildjihye = true;
        }

        if (ChangeBuild.LeeHaneul == true && Money.money >= 13 && buildhaneul == false)
        {
            Money.money -= 13;
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            buildhaneul = true;
        }

        if (ChangeBuild.Hanjiyun == true && Money.money >= 20 && buildjiyun == false)
        {
            Money.money -= 20;
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            buildjiyun = true;

        }
        if (ChangeBuild.Anseyeong == true && Money.money >= 27 && buildseyeong == false)
        {
            Money.money -= 27;
            turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
            buildseyeong = true;
        }



    }



    //마우스 관련 함수들 이후 웨이브 정비 시간에만 사용 가능하게 변경하기

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
        ChangeAlpha(hoverAlpha);


    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
        ChangeAlpha(normalAlpha);
    }

    void ChangeAlpha(float alpha)
    {
        Color color = rend.material.color;
        color.a = alpha;
        rend.material.color = color;
    }


    IEnumerator StartNodes()
    {

        Color color = hoverColor;
        bool colorcheck = false;

        do
        {
            currentTime += Time.deltaTime / fadeTime;
            color.a = Mathf.Lerp(0, 1, currentTime);
            rend.material.color = color;
            yield return null;
        }
        while (color.a < 1 && colorcheck == false);



        colorcheck = true;

        do
        {
            currentTime2 += Time.deltaTime / fadeTime;
            color.a = Mathf.Lerp(1, 0, currentTime2);
            rend.material.color = color;
            yield return null;


        }
        while (color.a > 0 && colorcheck == true);



    }




    // 마우스 아래에 있는 대상 레이어의 오브젝트 찾기
    bool UnderMouse()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // 레이어 마스크를 사용해 특정 레이어에 속한 오브젝트만 감지
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, playerLayerMask))
        {
            return true;
        }

        return false; // 타겟이 없으면 false 반환
    }

    private void OnTriggerEnter(Collider other)
    {
        int layer = other.gameObject.layer;

        if (layer==LayerMask.NameToLayer("Player"))
        { 
            gameObject.layer= LayerMask.NameToLayer("BuildNode");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        int layer = other.gameObject.layer;

        if (layer == LayerMask.NameToLayer("Player"))
        {
            gameObject.layer = LayerMask.NameToLayer("Node");
        }
    }
}
